using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public int itemID;
    [SerializeField]
    private GameObject shopItem;

    private Transform InventoryContent;

    // Start is called before the first frame update
    void Awake()
    {
        InventoryContent = Main.inventoryContent.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonPress()
    {
        if (Main.money >= Main.cost[itemID])
        {
            Main.money -= Main.cost[itemID];
            if (Main.ownedItems[itemID] == 0)
            {
                GameObject newShopItem = Instantiate(shopItem, InventoryContent);
                newShopItem.SetActive(true);
            }
            Main.ownedItems[itemID]++;
        }
    }
}
