using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    Vector3 pos;                                // For movement
    float speed = 2.0f;                         // Speed of movement

    public Animator anim;

    public Text text;

    [SerializeField]
    private Rigidbody rb2d;

    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;

    [SerializeField]
    bool talkingToNPC = false;

    [SerializeField]
    bool doneTalking = false;

    public string[] dialogue1;

    [SerializeField]
    private int x1 = 0;

    [SerializeField]
    private int doneTalkingInt1;

    [SerializeField]
    private float rayDistance;

    public Vector3 lookDirection;

    void Start()
    {
        pos = transform.position;          // Take the initial position
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

            if (Input.GetKey(KeyCode.LeftArrow) && transform.position == pos && talkingToNPC == false)
            {        // Left
                anim.Play("LeftStill");
                if (Input.GetKey(KeyCode.LeftArrow) && left == true)
                {
                    pos += Vector3.left;
                    anim.SetBool("Left", true);
                }
                left = true;
                right = false;
                up = false;
                down = false;
                lookDirection = Vector3.left;
            }

            if (Input.GetKey(KeyCode.RightArrow) && transform.position == pos && talkingToNPC == false)
        {        // Right
            anim.Play("RightStill");
            if (Input.GetKey(KeyCode.RightArrow) && right == true)
            {
                pos += Vector3.right;
                anim.SetBool("Right", true);
            }
            right = true;
            left = false;
            up = false;
            down = false;
            lookDirection = Vector3.right;


        }

            if (Input.GetKey(KeyCode.UpArrow) && transform.position == pos && talkingToNPC == false)
            {        // Up
                anim.Play("ForwardStill");
                if (Input.GetKey(KeyCode.UpArrow) && up == true)
                {
                    pos += Vector3.forward;
                    anim.SetBool("Up", true);
                }
                up = true;
                left = false;
                right = false;
                down = false;
                lookDirection = Vector3.forward;
            }
        
            if (Input.GetKey(KeyCode.DownArrow) && transform.position == pos && talkingToNPC == false)
            {        // Down
                anim.Play("DownStill");
                if (Input.GetKey(KeyCode.DownArrow) && down == true)
                {
                    pos += Vector3.back;
                    anim.SetBool("Down", true);
                }
                down = true;
                left = false;
                up = false;
                right = false;
                lookDirection = Vector3.forward;
            }
        


        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there



        //Animation Handler
        if (transform.position == pos)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }

        //if (transform.position == pos && Input.GetKeyDown(KeyCode.Return))
        //{
        //    // Cast a ray 1 Unity Unit in the lookDirection
        //    RaycastHit hit; 

        //    // If it hits an NPC...
        //    if (Physics.Raycast(transform.position, lookDirection, out hit, rayDistance) && hit.collider.tag == "NPC")
        //    {
        //        text.enabled = true;
        //        talkingToNPC = true;
        //    }
        //}

     }




    void Update()
    {

        if (talkingToNPC)
        {
            text.text = dialogue1[x1];

            if (Input.GetKeyDown(KeyCode.Return))
            {
                x1++;
            }

            if (x1 < 3)
            {
                text.text = dialogue1[x1];
            }

            if (x1 == 3 && Input.GetKeyDown(KeyCode.Return))
            {
                doneTalking = true;
            }
        }
        if (doneTalking)
        {
            text.enabled = false;
            talkingToNPC = false;
            doneTalking = false;
        }

    }

}
