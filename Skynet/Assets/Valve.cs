using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour {

    //Collider c;
    public bool IsOpen;

	// Use this for initialization
	void Start () {
        //c = GetComponent<Collider>();
	}

    public void Open()
    {
        //c.isTrigger = true;
        IsOpen = true;
    }

    public void Close()
    {
        //c.isTrigger = false;
        IsOpen = false;
    }
}
