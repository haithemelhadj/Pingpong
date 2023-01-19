using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballandgoal : MonoBehaviour
{
    // public bool isplayer1;
    public GameObject ball;
    public float speed;
    public Rigidbody2D rb;
    public int g1, g2=0;
    public float mvnt;
    public float x, y;
    public Text goal1, goal2;

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(0, 2) == 0 ? -1 : 1;
        y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity= new Vector2(speed * x, speed * y);

       

    }

    // Update is called once per frame
    void Update()
    {
        goal1.text = g1.ToString();
        goal2.text = g2.ToString();
        rb.velocity = new Vector2(speed * x, speed * y);
        
    }

    
   


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {




            x = -x;
            speed += 0.05f;
        }
        else if (collision.gameObject.tag == "feild")
        {
            y = -y;
            speed += 0.05f;
        }
        else if (collision.gameObject.tag == "goal1")
        {
            ball.transform.position=new Vector2(0,0);
            g1++;
            
        }
        else if (collision.gameObject.tag == "goal2")
        {
            ball.transform.position = new Vector2(0, 0);
            g2+=1;
            
        }
    }
}
