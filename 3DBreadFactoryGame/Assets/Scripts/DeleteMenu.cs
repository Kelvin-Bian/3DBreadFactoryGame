using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMenu : MonoBehaviour
{
    public GameObject shop;
    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonPress()
    {
            shop.SetActive(false);
            item.SetActive(true);
    }
}
