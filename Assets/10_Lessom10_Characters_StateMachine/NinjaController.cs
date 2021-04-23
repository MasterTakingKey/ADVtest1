using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    [SerializeField]
    private float accelerationDown;

    private Animator animator;
    private CharacterController controller;
    private bool isRunning;
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //controller.Move(Vector3.down* accelerationDown*Time.deltaTime);
        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", 0);
        isRunning = false;
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("vertical", 1);
            /*
            if (isRunning)
                animator.SetFloat("vertical", 1f);
            else
                animator.SetFloat("vertical", 0.5f);
                */
        }
        
        else
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("vertical", -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("horizontal", -1);
        }else
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("horizontal", 1);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
        }
    }
}
