using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreGroundContactDelete : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ore")) Destroy(other.gameObject);
    }
}
