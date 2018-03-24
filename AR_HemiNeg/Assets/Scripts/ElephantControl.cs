using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantControl : MonoBehaviour {

    private float timerInterval = 2f;
    private float timerTime = 0f;
    private bool timerActive;

    public bool HasEscaped = false;

    // Use this for initialization
    void Start () {
        timerActive = false;
        timerTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timerTime += Time.deltaTime;
            if (timerTime >= timerInterval)
            {
                transform.localScale = new Vector3(2f, 2f, 2f);
                timerActive = false;
                timerTime = 0.0f;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            TeleportRandomly();
            HasEscaped = true;
            timerActive = true;
            timerTime = 0.0f;
            transform.localScale = new Vector3(1f, 1f, 1f);

        }

    }
    void OnTriggerExit(Collider col)
    {
        this.GetComponent<Renderer>().enabled = true;
        
    }

    public void TeleportRandomly()
    {
        Vector3 jump = new Vector3(0.0f, 0.0f, -5.0f);
        transform.localPosition += jump;
    }
}
