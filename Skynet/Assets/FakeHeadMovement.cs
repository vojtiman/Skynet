using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeHeadMovement : MonoBehaviour {

    public Valve v;
    public GameObject HeadsWaitingGO;
    public float Speed;

    bool moving;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!moving && v.IsOpen && HeadsWaitingGO.transform.childCount > 0)
        {
            moving = true;
            GameObject head = HeadsWaitingGO.transform.GetChild(0).gameObject;
            StartMoveHead(head);
        }
	}

    void StartMoveHead(GameObject head)
    {
        head.transform.parent = transform.parent;

        head.GetComponent<Collider>().isTrigger = true;

        var rb = head.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;      
        
        StartCoroutine(MoveHead(head));
    }

    IEnumerator MoveHead(GameObject head)
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            Vector3 target = transform.GetChild(i).position;
            while (true)
            {
                head.transform.position = Vector3.MoveTowards(head.transform.position, target, Speed * Time.smoothDeltaTime);
                if (head.transform.position == target)
                {
                    break;
                    //yield return null;
                }

                yield return new WaitForSeconds(0.01f);
            }          
        }
    }
}
