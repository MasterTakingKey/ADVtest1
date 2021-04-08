using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloralBehaviour : MonoBehaviour
{
    public Animator FloralAnim;
    public AudioSource sonido;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*bool FlorarlDown = FloralAnim.GetCurrentAnimatorStateInfo(1).IsName("FloralDown");
        string stateInfo = FloralAnim.tra
        //Debug.Log("FlorarlDown: " + FlorarlDown);
        Debug.Log("stateInfo: " + stateInfo);*/

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider activado");
        FloralAnim.SetBool("FloralUp", false);
        //sonido.Play();

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider desactivado");
        FloralAnim.SetBool("FloralUp", true);
        //sonido.Stop();
    }
}
