using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.gameObject.name == other.transform.tag)
        {
            gameObject.transform.position = other.transform.position;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.transform.Rotate(0,other.transform.rotation.y,0);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
    
}
