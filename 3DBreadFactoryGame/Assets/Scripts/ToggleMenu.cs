using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMenu : MonoBehaviour
{
    [SerializeField]
    private Transform categoryMenu;
    [SerializeField]
    private GameObject targetCategory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPress()
    {
        foreach (Transform category in categoryMenu)
        {
            category.gameObject.SetActive(false);
        }
        targetCategory.SetActive(true);
    }
}
