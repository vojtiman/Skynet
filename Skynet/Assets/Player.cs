using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject Tube;

    bool requestLeft;
    bool requestRight;

    public float TargetXPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            requestLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            requestRight = true;
        }

        if (requestLeft == requestRight)
            return;

        if (requestLeft)
            StartCoroutine(GoLeft());

        if (requestRight)
            StartCoroutine(GoRight());
    }

    IEnumerator GoLeft()
    {
        yield return null;
    }

    IEnumerator GoRight()
    {
        yield return null;
    }
}
