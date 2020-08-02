using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderForParent : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Building") GetComponentInParent<PlaceItem>().colliding = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Building") GetComponentInParent<PlaceItem>().colliding = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Building") GetComponentInParent<PlaceItem>().colliding = true;
    }
}
