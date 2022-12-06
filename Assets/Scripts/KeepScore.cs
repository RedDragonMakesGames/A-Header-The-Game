using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public ScoreDisplay scoreCounter;
    public int scoreForBounce = 1;
    public Sprite headerNormal;
    public Sprite headerHeaded;
    public int headerSpriteTime = 5;

    private int headerSpriteTicks = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            scoreCounter.IncreaseScore(scoreForBounce);
            headerSpriteTicks = headerSpriteTime;
        }
            
    }

    private void FixedUpdate()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (headerSpriteTicks > 0)
        {
            sprite.sprite = headerHeaded;
            headerSpriteTicks--;
        }
        else
        {
            sprite.sprite = headerNormal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
