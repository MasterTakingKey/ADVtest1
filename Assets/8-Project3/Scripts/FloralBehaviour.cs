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
       FloralAnim.SetBool("FloralUp", false);
        

    }

    void OnTriggerExit(Collider other)
    {
       FloralAnim.SetBool("FloralUp", true);
    }
}
