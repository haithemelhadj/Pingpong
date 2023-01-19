using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepl : MonoBehaviour
{
    public bool isplayer1;
    public float speed;
    public Rigidbody2D rb;

    private float mvnt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isplayer1)
        {
            mvnt = Input.GetAxisRaw("Vertical");
        }
        else
        {
            mvnt = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, mvnt * speed);
    }
}


