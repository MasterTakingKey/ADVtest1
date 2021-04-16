using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator DoorsAnimator;
    private const string animBoolName = "isOpen_Obj_";
    public int number;
    public AudioSource sonidoAbrir;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       DoorsAnimator.SetBool(animBoolName + number, true);
        sonidoAbrir.Play();


    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider de la puerta " + animBoolName + number + " desactivado");
        DoorsAnimator.SetBool(animBoolName + number, false);
    
    }
}
