using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    /// <summary>
    /// Handles Player Animations.
    /// </summary>

    

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //If Horizontal > or < O, switch direction of animation

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetFloat("Movement", 1);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetFloat("Movement", -1);
        }
        else
        {
            animator.SetFloat("Movement", 0);
        }
    }
}
