using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAlturaBlendTree : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbody;
    public Animator animatorPelota;
    public Animator animatorCofre;
    bool abierto;

    void Start()
    {
        abierto = animatorCofre.GetBool("abierto");
    }

    // Update is called once per frame
    void Update()
    {
        animatorPelota.SetFloat("aLTURA", (altura / 6f));
        if (Input.GetKey(KeyCode.O))
        {
            animatorCofre.SetBool("abierto", true);
        }
        
        if (Input.GetKey(KeyCode.P))
        {
            animatorCofre.SetBool("abierto", false);
        }

    }
    float altura = 0f;
    private void FixedUpdate()
    {
        altura = GetComponent<Rigidbody>().position.y;
    }
}
