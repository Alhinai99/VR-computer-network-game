using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSecript : MonoBehaviour
{
    [SerializeField]
    GameObject partPrefab, parentObject;
    
    [SerializeField]
    [Range(1,1000)]
    int length = 1;

    [SerializeField]
    float partDistance = 0.21f;

    [SerializeField]
    bool reset, spwan, snapFirst, snapLast;


    void Update()
    {
        if (reset)
        {
            foreach (GameObject tmp in GameObject.FindGameObjectsWithTag("Wire"))
            {
                Destroy(tmp);
            }
            reset = false;
        }
        if (spwan)
        {
            Spawn();
            spwan = false;
        }
    }
    public void Spawn()
    {
        int conut = (int)(length / partDistance);

        for(int x = 0; x < conut; x++)
        {
            GameObject tmp;
            tmp = Instantiate(partPrefab, new Vector3(transform.position.x, transform.position.y * partDistance * (x + 1), transform.position.z), Quaternion.identity, parentObject.transform);

            tmp.transform.eulerAngles = new Vector3(180,0,0);

            tmp.name = parentObject.transform.childCount.ToString();

            if(x== 0)
            {
                Destroy(tmp.GetComponent<CharacterJoint>());
                if (snapFirst)
                {
                    tmp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                }

            }
            else
            {
                tmp.GetComponent<CharacterJoint>().connectedBody = parentObject.transform.Find((parentObject.transform.childCount - 1).ToString()).GetComponent<Rigidbody>();
            }

        }
        if (snapLast)
        {
            parentObject.transform.Find((parentObject.transform.childCount).ToString()).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
