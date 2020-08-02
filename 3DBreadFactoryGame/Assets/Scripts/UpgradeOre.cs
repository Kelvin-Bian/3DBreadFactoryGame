using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeOre : MonoBehaviour
{
    [SerializeField]
    private int valueAdd, valueMult;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ore"))
        {
            other.gameObject.GetComponent<OreValue>().value += valueAdd;
            other.gameObject.GetComponent<OreValue>().value *= valueMult;
        }
    }
}
