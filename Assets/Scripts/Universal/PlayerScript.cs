using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    Vector3 pos;                                // For movement
    float speed = 2.0f;                         // Speed of movement

    public Animator anim;

    //public bool talks;
    //public string message;
    //https://www.youtube.com/watch?v=N_0fyhmoZ0Y

    public Text text;

    [SerializeField]
    private Rigidbody rb2d;

    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;

    public Vector3 rayVectorAid = Vector3.zero;
    float Vectorx;
    float Vectorz;

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

    int layerMask = 1 << 9;

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
                rayVectorAid = transform.position;
                Vectorx = -4f;
                rayVectorAid.x = rayVectorAid.x + Vectorx;
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
            rayVectorAid = transform.position;
            Vectorx = 4f;
            rayVectorAid.x = rayVectorAid.x + Vectorx;
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
                rayVectorAid = transform.position;
                Vectorz = 4f;
                rayVectorAid.z = rayVectorAid.z + Vectorz;
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
                rayVectorAid = transform.position;
                Vectorz = -4f;
                rayVectorAid.z = rayVectorAid.z + Vectorz;
                lookDirection = Vector3.back;
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

        if (transform.position == pos && Input.GetKeyDown(KeyCode.Return))
        {
            RaycastHit hit;

            // If it hits an NPC...
            if (Physics.Raycast(rayVectorAid, transform.TransformDirection(lookDirection), out hit, rayDistance, layerMask))
                {
                rayVectorAid = Vector3.zero;
                text.enabled = true;
                talkingToNPC = true;
            }
        }

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
