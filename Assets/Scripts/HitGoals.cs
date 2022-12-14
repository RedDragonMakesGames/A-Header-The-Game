using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGoals : MonoBehaviour
{
    public ScoreDisplay score;
    public int pointsForGoal = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            score.IncreaseScore(pointsForGoal);
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
