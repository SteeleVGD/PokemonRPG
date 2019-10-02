using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GrassAnim : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public bool shakeGrass;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(shakeGrass == true)
        {
            animator.SetBool("Shake", true);
        }
        else
        {
            animator.SetBool("Shake", false);
        }


    }
}
