using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    public GameObject loseText;
    public Transform topLeft;
    public Transform bottomRight;
    public GameObject ball;
    public ScoreDisplay score;
    public GoalSpawnManager goalSpawner;

    private bool gameLost = false;
    private GameObject currentBall;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameLost = true;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            currentBall = collision.gameObject;
            loseText.SetActive(true);
        }
    }

    private void FixedUpdate()
    {

    }

    private void SpawnBall()
    {
        float x = Random.Range(topLeft.position.x, bottomRight.position.x);
        float y = Random.Range(topLeft.position.y, bottomRight.position.y);
        GameObject ballInst = Instantiate(ball, new Vector3(x, y), Quaternion.Euler(new Vector3(0, 0, 0)));
        ballInst.GetComponent<HitGoals>().score = score;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameLost)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(currentBall);
                currentBall = null;
                score.SetScore(0);
                loseText.SetActive(false);
                gameLost = false;
                goalSpawner.DestroyAllGoals();
                SpawnBall();
            }
        }
    }
}
