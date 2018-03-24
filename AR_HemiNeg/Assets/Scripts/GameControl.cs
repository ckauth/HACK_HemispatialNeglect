using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    // hunter
    public GameObject Elephant;
    public GameObject Giraffe;

    // huntee
    public GameObject Mouse;
    public GameObject Tiger;

    // time
    private float timerInterval = 2f;
    private float timerTime = 0f;

    // Use this for initialization
    void Start () {
        Elephant.SetActive(true);
        Giraffe.SetActive(true);

        Mouse.SetActive(false);
        Tiger.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (Elephant.activeSelf && Elephant.GetComponent<ElephantControl>().HasEscaped)
        {
            ToggleHunterAndHuntee();
            Elephant.GetComponent<ElephantControl>().HasEscaped = false;
        }
        var a = Giraffe;
        if (Giraffe.activeSelf && Giraffe.GetComponent<GiraffeControl>().HasEscaped)
        {
            ToggleHunterAndHuntee();
            Giraffe.GetComponent<GiraffeControl>().HasEscaped = false;
        }

        timerTime += Time.deltaTime;
        if (timerTime >= timerInterval)
        {
            timerTime = 0f;
        }
    }

    void ToggleHunterAndHuntee() {
        if (Mouse.activeSelf)
        {
            Mouse.SetActive(false);
            Elephant.GetComponent<Collider>().enabled = false;

            Tiger.SetActive(true);
            Giraffe.GetComponent<Collider>().enabled = true;
        }
        else
        {
            Mouse.SetActive(true);
            Elephant.GetComponent<Collider>().enabled = true;

            Tiger.SetActive(false);
            Giraffe.GetComponent<Collider>().enabled = false;
        }
    }
}
