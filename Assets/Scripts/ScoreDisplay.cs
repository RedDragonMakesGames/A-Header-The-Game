using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    public void DecreaseScore(int amount) 
    { 
        score -= amount;
    }

    public void SetScore(int targetScore)
    {
        score = targetScore;
    }

    public int GetScore()
    {
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        SetText();
    }

    void SetText()
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        if (text != null)
        {
            text.text = ("Score: ") + score.ToString();
        }
    }
}
