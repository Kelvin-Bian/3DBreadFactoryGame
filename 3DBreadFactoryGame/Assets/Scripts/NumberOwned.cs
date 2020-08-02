using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberOwned : MonoBehaviour
{
    private TextMeshProUGUI Text;
    [SerializeField]
    private int itemID;
    [SerializeField]
    private GameObject placeItem;

    // Start is called before the first frame update
    void Awake()
    {
        Text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Owned: " + Main.ownedItems[itemID].ToString();
    }
    public void OnPress()
    {
        Main.ownedItems[itemID]--;
        placeItem.SetActive(true);
        Main.inventory.SetActive(false);
        if (Main.ownedItems[itemID] == 0)
        {
            Destroy(this.gameObject.GetComponent<Transform>().parent.gameObject);
        }
    }
}
