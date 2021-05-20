using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    [SerializeField]
    private float accelerationDown;

    private AudioSource[] sounds;
    private AudioSource walking;
    private Animator animator;
    private CharacterController controller;
    private bool isRunning;
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        sounds = GetComponents<AudioSource>();
        walking = sounds[1];
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
            //walking.Play();
   
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
