using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraffeControl : MonoBehaviour
{

    private float timerInterval = 2f;
    private float timerTime = 0f;
    private bool timerActive;

    public bool HasEscaped = false;

    // Use this for initialization
    void Start()
    {
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
        }

    }
    void OnTriggerExit(Collider col)
    {
        this.GetComponent<Renderer>().enabled = true;
    }

    public void TeleportRandomly()
    {
        Vector3 direction = Random.onUnitSphere;
        //direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
        direction.y = 0f;
        direction.x = Mathf.Clamp(direction.x, 0.5f, 1f);
        direction.z = Mathf.Clamp(direction.y, 0.5f, 1f);
        float distance = 10 * Random.value + 1.5f;
        transform.localPosition = direction * distance;
    }
}
