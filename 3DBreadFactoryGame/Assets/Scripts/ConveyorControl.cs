using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorControl : MonoBehaviour
{
    [SerializeField]
    private int speed;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ore")) other.gameObject.GetComponent<Rigidbody>().velocity = speed * GetComponentInParent<Transform>().forward;
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ore")) other.gameObject.GetComponent<Rigidbody>().velocity = speed * GetComponentInParent<Transform>().forward;
    }
}
