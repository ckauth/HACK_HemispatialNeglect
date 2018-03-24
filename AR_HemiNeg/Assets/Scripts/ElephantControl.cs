using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            GetComponent<Renderer>().enabled = false;
        }

    }
    void OnTriggerExit(Collider col)
    {
        this.GetComponent<Renderer>().enabled = true;
    }
}
