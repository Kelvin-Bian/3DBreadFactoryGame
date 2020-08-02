using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseBuyMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject buyMenu,inventory;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            inventory.SetActive(!inventory.activeSelf);
            buyMenu.SetActive(false);
        }
        if (Input.GetKeyDown("f"))
        {
            buyMenu.SetActive(!buyMenu.activeSelf);
            inventory.SetActive(false);
        }
    }
}
