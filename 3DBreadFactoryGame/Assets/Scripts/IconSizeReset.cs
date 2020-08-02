using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSizeReset : MonoBehaviour
{
    [SerializeField]
    private Transform inventoryIcons;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (Main.prevText != null) Main.prevText.SetActive(false);
        Main.frameIcon.sprite = null;
        Main.infoFrame.SetActive(!Main.infoFrame.activeSelf);
        foreach (Transform icon in inventoryIcons)
        {
            icon.localScale = new Vector2(1f, 1f);
        }
    }
    private void OnDisable()
    {
        if (Main.prevText != null) Main.prevText.SetActive(false);
        Main.frameIcon.sprite = null;
        Main.infoFrame.SetActive(!Main.infoFrame.activeSelf);
    }
}
