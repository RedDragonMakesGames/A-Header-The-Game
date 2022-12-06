using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCheck : MonoBehaviour
{
    public float maxYSpeed = 100.0f;

    private Rigidbody2D rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody= GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rBody.velocity.y > maxYSpeed)
        {
            rBody.velocity = new Vector2(rBody.velocity.x, maxYSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
