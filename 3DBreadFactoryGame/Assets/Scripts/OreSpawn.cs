using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject ore;
    [SerializeField]
    private int time;
    private bool running;
    // Start is called before the first frame update
    void Start()
    {
        running = true;
    }
    // Update is called once per frame
    public void Update()
    {
        if(running)
        {
            StartCoroutine(SpawnOre(time));
        }
        
    }

    public IEnumerator SpawnOre(int time)
    {
        running = false;
        yield return new WaitForSeconds(time);
        Instantiate(ore, transform.position, Quaternion.identity);
        running = true;
    }

}
