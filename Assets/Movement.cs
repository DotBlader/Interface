using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.05f;
    public Rigidbody2D rbody;
    public ClickScript clickScript;
    public HitBox hitboxBottom;
    public HitBox hitboxTop;
    public HitBox hitboxLeft;
    public HitBox hitboxRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clickScript.move == true)
        {
            if (hitboxBottom.isTouching == true && clickScript.mousePos.y < transform.position.y)
            {
                clickScript.move = false;
                print("bottom");
            }
            else if (hitboxTop.isTouching == true && clickScript.mousePos.y > transform.position.y)
            {
                clickScript.move = false;
                print("top");
            }
            else if (hitboxLeft.isTouching == true && clickScript.mousePos.x < transform.position.x)
            {
                clickScript.move = false;
                print("left");
            }
            else if (hitboxRight.isTouching == true && clickScript.mousePos.x > transform.position.x)
            {
                clickScript.move = false;
                print("right");
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, clickScript.mousePos, speed);
            }
            if (transform.position.x == clickScript.mousePos.x && transform.position.y == clickScript.mousePos.y)
            {
                clickScript.move = false;
            }
        }
    }
}
