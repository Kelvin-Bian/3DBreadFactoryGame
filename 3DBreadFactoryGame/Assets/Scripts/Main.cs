using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static double money;
    [SerializeField]
    private float income;
    [SerializeField]
    private int startMoney;
    public static Sprite[] sprites;
    public static int[] ownedItems;
    public static int[] cost;
    [SerializeField]
    private int[] SetCost;
    public static GameObject prevText;

    //below are constant variable references
    [SerializeField]
    private GameObject setInventory,setInfoFrame,setInventoryContent;
    [SerializeField]
    private Image setFrameIcon;
    [SerializeField]
    private LayerMask setBuildingsLayer, setGroundLayer;

    public static GameObject inventory,infoFrame,inventoryContent;
    public static Image frameIcon;
    public static LayerMask buildingsLayer, groundLayer;


    private bool running = true;

    private void Awake()
    {
        money = startMoney;
        sprites = Resources.LoadAll<Sprite>("SpriteImages/ShopSprites");
        cost = new int[SetCost.Length];
        for (int i = 0; i < SetCost.Length; i++)
        {
            cost[i] = SetCost[i];
        }
        ownedItems = new int[sprites.Length];

        //below set constant variable references
        inventory = setInventory;
        infoFrame = setInfoFrame;
        frameIcon = setFrameIcon;
        inventoryContent = setInventoryContent;
        buildingsLayer = setBuildingsLayer;
        groundLayer = setGroundLayer;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        money+=(income);

        if (running)
        {
            StartCoroutine(SpawnOre(1));
        }
    }
    public IEnumerator SpawnOre(int time)
    {
        running = false;
        yield return new WaitForSeconds(time);
        running = true;
    }
}
