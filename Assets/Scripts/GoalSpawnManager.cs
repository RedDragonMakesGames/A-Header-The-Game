using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawnManager : MonoBehaviour
{
    int scoreToStartSpawning = 5;
    public ScoreDisplay score;
    public GameObject goal;
    public Transform topLeft;
    public Transform bottomRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyAllGoals()
    {
        int children = gameObject.transform.childCount;
        for (int i = 0; i < children; i++)
        {
            Destroy(gameObject.transform.GetChild(i).gameObject);
        }
    }

    private void FixedUpdate()
    {
        int currentScore = score.GetScore();
        if (currentScore >= scoreToStartSpawning)
        {
            if (gameObject.transform.childCount == 0)
            {
                float x = Random.Range(topLeft.position.x, bottomRight.position.x);
                float y = Random.Range(topLeft.position.y, bottomRight.position.y);
                GameObject goalInst = Instantiate(goal, new Vector3(x,y), Quaternion.Euler(new Vector3(0,0,0)));
                goalInst.transform.parent = transform;
            }
        }
    }
}
