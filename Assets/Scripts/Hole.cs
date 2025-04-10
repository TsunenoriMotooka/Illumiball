using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;
    bool isHolding;

    public bool IsHolding()
    {
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            isHolding = true;
        }        
    }

    void OggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            isHolding = false;
        }        
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        //ホールからボールへのベクトル
        Vector3 direction = other.gameObject.transform.position - transform.position; 
        //長さを１にする
        direction.Normalize();
        
        if (other.CompareTag(targetTag))
        {
            r.velocity *= 0.9f;
            r.AddForce(direction * -20.0f, ForceMode.Acceleration);        
        }
        else
        {
            r.AddForce(direction * 80f, ForceMode.Acceleration);
        }    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
