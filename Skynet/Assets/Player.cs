using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject TubeGO;
    public float TargetXPosition;
    public float Speed;

    Transform Tube;
    bool requestLeft;
    bool requestRight;

    bool requestMid;
    bool sideReached;
    bool returning;

    // Use this for initialization
    void Start () {
        Tube = TubeGO.transform;
    }
	
	// Update is called once per frame
	void Update () {

        if (sideReached && !returning)
            StartGoMiddle();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
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
            StartGoLeft();

        if (requestRight)
            StartGoRight();

        requestLeft = false;
        requestRight = false;
    }

    void StartGoLeft()
    {
        StopAllCoroutines();
        Vector3 target = new Vector3(-TargetXPosition, Tube.position.y, Tube.position.z);
        StartCoroutine(GoToTarget(target));
    }

    void StartGoRight()
    {
        StopAllCoroutines();
        Vector3 target = new Vector3(TargetXPosition, Tube.position.y, Tube.position.z);
        StartCoroutine(GoToTarget(target));
    }

    void StartGoMiddle()
    {
        returning = true;
        StopAllCoroutines();
        Vector3 mid = new Vector3(0, Tube.position.y, Tube.position.z);
        StartCoroutine(GoMid(mid));
    }

    IEnumerator GoToTarget(Vector3 target)
    { 
        while (true)
        {
            Tube.position = Vector3.MoveTowards(Tube.position, target, Speed * Time.smoothDeltaTime);
            if (Tube.position == target)
            {
                sideReached = true;
                yield return null;
            }       

            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator GoMid(Vector3 mid)
    {  
        while (true)
        {
            Tube.position = Vector3.MoveTowards(Tube.position, mid, Speed * Time.smoothDeltaTime);
            if (Tube.position == mid)
            {
                sideReached = false;
                returning = false;
                yield return null;
            }

            yield return new WaitForSeconds(0.01f);
        }
    }
}
