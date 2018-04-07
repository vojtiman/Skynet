using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeads : MonoBehaviour {

    public FakeHeadMovement fhm;
    public Health health;

    void OnTriggerEnter(Collider other)
    {
        GameObject o = other.gameObject;
        if (o.tag == "Head")
        {
            fhm.HeadCollected();

            if(o.name == gameObject.name)
            {
                health.Heal();
            }
            else
            {
                health.TakeDmg();
            }

            o.GetComponent<RemoveMe>().DisableAndRemove();
        }
    }
}
