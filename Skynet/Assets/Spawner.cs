using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject headTemplates;
    public GameObject Heads;

    float minWaitTime = 1.0f;
    public float maxWaitTime;

    public float maxForce;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnHead());     
    }

    IEnumerator SpawnHead()
    {
        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            GameObject headTemplate = getRandomHeadTemplate();

            GameObject newHead = Instantiate(headTemplate, transform.position, Quaternion.identity) as GameObject;

            newHead.name = headTemplate.name;
            newHead.transform.parent = Heads.transform;

            newHead.GetComponent<Rigidbody>().AddForce(0, -Random.Range(0, maxForce), 0, ForceMode.Impulse);

            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
        }
    }

    GameObject getRandomHeadTemplate()
    {
        int idx = Random.Range(0, headTemplates.transform.childCount);
        return headTemplates.transform.GetChild(idx).gameObject;
    }
}
