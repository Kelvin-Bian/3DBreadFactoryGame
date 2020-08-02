using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSizeToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject text;
    [SerializeField]
    private Sprite icon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCursorEnter()
    {
        this.transform.localScale = this.transform.localScale * new Vector2(1.25f, 1.25f);
        Main.prevText = text;
        text.SetActive(true);
        Main.frameIcon.sprite = icon;
    }

    public void OnCursorExit()
    {
        this.transform.localScale = this.transform.localScale * new Vector2(.8f, .8f);
        Main.prevText = null;
        text.SetActive(false);
        Main.frameIcon.sprite = null;
    }
}
