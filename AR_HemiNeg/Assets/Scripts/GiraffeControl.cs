using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GiraffeControl : MonoBehaviour
{

    private float timerInterval = 2f;
    private float timerTime = 0f;
    private bool timerActive;

    public bool HasEscaped = false;
    public AudioClip sound;
    AudioSource audioSource;
    
    // Use this for initialization
    void Start()
    {
        timerActive = false;
        timerTime = 0f;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timerTime += Time.deltaTime;
            if (timerTime >= timerInterval)
            {
                //timerActive = false;
                timerTime = 0f;
                TeleportRandomly();
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            TeleportRandomly();
            HasEscaped = true;
            //timerActive = true;
            audioSource.Play();
        }

    }
    void OnTriggerExit(Collider col)
    {
        this.GetComponent<Renderer>().enabled = true;
    }

    public void TeleportRandomly()
    {
    }
}
