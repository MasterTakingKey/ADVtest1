using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehaviour : MonoBehaviour
{
    public Animator HandAnim;
    public float heightEscale;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandAnim.SetFloat("Height", (altura / heightEscale));
    }

    float altura = 0f;
    private void FixedUpdate()
    {
        altura = GetComponent<Rigidbody>().position.y;
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collider activado");
        HandAnim.SetTrigger("HandInteraction");

    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Collider desactivado");
        

    }

}
