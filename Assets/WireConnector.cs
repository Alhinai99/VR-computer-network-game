using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireConnector : MonoBehaviour
{
    public GameObject netobject; 
    public GameObject buttonObject;
    public GameObject wire;
    public GameObject port;
    [SerializeField] float speed = 1;


    public float connectionDistance = 1.5f;
    

    private bool isConnected = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == netobject && !isConnected)
        {
            
            Connect();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == netobject && isConnected)
        {
            Disconnect();
        }
    }

    private void Connect()
    {
        
        isConnected = true;
        buttonObject.SetActive(true);
        


    }

    private void Disconnect()
    {
        isConnected = false;
        buttonObject.SetActive(false);
        
    }

    private void Update()
    {
        if (isConnected)
        {
            wire.transform.position = Vector3.MoveTowards(wire.transform.position, port.transform.position, speed * Time.deltaTime);
        }
        
    }
}
