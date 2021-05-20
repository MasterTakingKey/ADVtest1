using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitController : MonoBehaviour
{
    private Animator playerAnimator;
    void Start()
    {
        playerAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        playerAnimator.SetTrigger("Limit");
        Debug.Log("Limite, media vuelta");
    }
}
