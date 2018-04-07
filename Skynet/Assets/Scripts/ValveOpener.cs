using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveOpener : MonoBehaviour
{
    // Use this for initialization
    void Start()
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
