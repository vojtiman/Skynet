using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeads : MonoBehaviour {

    public FakeHeadMovement fhm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        GameObject o = other.gameObject;
        if (o.tag == "Head")
        {
            fhm.HeadCollected();

            if(o.name == gameObject.name)
            {
                print("hura");
            }
            else
            {
                print("spatny typ smrti, smula");
            }

            o.GetComponent<RemoveMe>().DisableAndRemove();
        }
    }
}
