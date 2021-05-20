using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject closet;
    private Animator closetAnimator;
    private AudioSource aparitionSound;
    bool showed;

    private GameObject lamps;

    private Animator playerAnimator;
    private float animStart;
    void Start()
    {
        closet = GameObject.FindGameObjectWithTag("Closet");
        closetAnimator = closet.GetComponent<Animator>();
        aparitionSound = GetComponent<AudioSource>();
        lamps = GameObject.Find("Lamps");
        lamps.SetActive(false);
        playerAnimator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        showed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - animStart > 0.7 && showed) 
        {
            lamps.SetActive(true);
        }
    }
    void OnTriggerEnter()
    {
        if (!showed) {
            Debug.Log("- Activa el armario");
            //closet.SetActive(true);
            closetAnimator.SetTrigger("Show");
            //Playsoundeffect
            playerAnimator.SetTrigger("Limit");
            aparitionSound.Play();
            animStart = Time.time;
            showed = true;

        }
    }
    
}
