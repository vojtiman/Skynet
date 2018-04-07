using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveOpener : MonoBehaviour
{

    public Valve Valve;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Valve")
        {
            other.GetComponent<Valve>().Open();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Valve")
        {
            other.GetComponent<Valve>().Close();
        }
    }
}
