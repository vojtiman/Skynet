using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeHeadMovement : MonoBehaviour {

    public Valve v;
    public GameObject HeadsWaitingGO;
    public float Speed;

    public GameObject Tube;

    public bool movingHead;

    // Use this for initialization
    void Start () {
		
	}

    public void HeadCollected()
    {
        //print("head collected");
        movingHead = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!movingHead && v.IsOpen && HeadsWaitingGO.transform.childCount > 0)
        {         
            movingHead = true;
            GameObject head = HeadsWaitingGO.transform.GetChild(0).gameObject;
            head.transform.SetParent(Tube.transform);
            //print("moving" + head.name);
            StartMoveHead(head);
        }
	}

    void StartMoveHead(GameObject head)
    {
        head.GetComponent<Collider>().isTrigger = true;

        var rb = head.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;

        head.transform.position = transform.GetChild(0).position;

        //TODO play sound

        StartCoroutine(MoveHead(head));
    }

    IEnumerator MoveHead(GameObject head)
    {
        head.transform.SetParent(Tube.transform);

        head.GetComponent<MeshRenderer>().enabled = false;
        head.transform.position = transform.GetChild(transform.childCount - 1).position;

        head.transform.SetParent(Tube.transform);

        yield return new WaitForSeconds(0.25f);
        head.GetComponent<MeshRenderer>().enabled = true;

        head.transform.SetParent(Tube.transform);//one more time, just to be sure xD
    }
}
