using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Animator animator;
    private bool walking;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            animator.SetTrigger("Jog");
            animator.ResetTrigger("Idle");
            walking = true;
        }

        if (Input.GetKeyUp(KeyCode.W)){
            animator.SetTrigger("Idle");
            animator.ResetTrigger("Jog");
            walking = false;
        }

        if (Input.GetKey(KeyCode.S)){
            animator.SetTrigger("JogBackwards");
            animator.ResetTrigger("Idle");
        }


        if (Input.GetKeyUp(KeyCode.S)){
            animator.SetTrigger("Idle");
            animator.ResetTrigger("JogBackwards");
        }

        if (Input.GetKeyDown(KeyCode.K)){
            animator.SetTrigger("Cross");
            animator.ResetTrigger("Jog");
            walking = false;
        }
    }
}
