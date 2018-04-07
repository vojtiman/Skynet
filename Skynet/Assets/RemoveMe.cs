using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMe : MonoBehaviour {

    public void DisableAndRemove()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().detectCollisions = false;

        Invoke("DestroyMe", 5.0f);
    }

    void DestoryMe()
    {
        Destroy(gameObject);
    }
}
