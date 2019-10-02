using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FloatTransformToInt : MonoBehaviour
{
    public Vector3 toInt;
    public Rigidbody2D rb2d;
    public Animator animator;

    public bool up;
    public bool left;
    public bool right;
    public bool down;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (up == true || down == true || left == true || right == true)
            {
                rb2d.velocity = new Vector2(0, 0);
                toInt = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), 0.1f);
                transform.position = toInt;


                up = false;
                down = false;
                left = false;
                right = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && up == false)
        {
            rb2d.velocity = new Vector2(0, 0);
            up = true;
            down = false;
            left = false;
            right = false;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && down == false)
        {
            rb2d.velocity = new Vector2(0, 0);
            down = true;
            up = false;
            left = false;
            right = false;
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && left == false)
        {
            rb2d.velocity = new Vector2(0, 0);
            left = true;
            right = false;
            up = false;
            down = false;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && right == false)
        {
            rb2d.velocity = new Vector2(0, 0);
            right = true;
            left = false;
            up = false;
            down = false;
        }
        else
        {
            right = false;
            left = false;
            up = false;
            down = false;
        }
    }
}
