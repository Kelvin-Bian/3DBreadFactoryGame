using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    [SerializeField]
    private float multiplier;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ore"))
        {
            Main.money += (other.gameObject.GetComponent<OreValue>().value * multiplier);
            Destroy(other.gameObject);
        }
    }
}
