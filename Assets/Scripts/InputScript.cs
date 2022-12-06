using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float breakSpeed = 2.0f;
    private Rigidbody2D rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody= GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float fasterBreaks = 1.0f;
        float inputVal = Input.GetAxisRaw("Horizontal");
        if (inputVal > 0 && rBody.velocity.x < 0)
            fasterBreaks = breakSpeed;
        else if (inputVal < 0 && rBody.velocity.x > 0)
            fasterBreaks = breakSpeed;
        rBody.AddForce(new Vector2(inputVal * moveSpeed * fasterBreaks, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
