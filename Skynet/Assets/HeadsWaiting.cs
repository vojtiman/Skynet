using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadsWaiting : MonoBehaviour {

    List<GameObject> heads;

    // Use this for initialization
    void Start()
    {
        heads = new List<GameObject>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Head")
        {
            heads.Add(other.gameObject);
        }
    }
}
