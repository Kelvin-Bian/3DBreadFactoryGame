using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour
{
    public GameObject items;
    public GameObject shop;

    private Vector2 mousePos;

    public LayerMask allTilesLayer;
    // Update is called once per frame
    private void Awake()
    {

    }
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x < -9)
        {
            mousePos.x = -9;
        }
        if (mousePos.x > 27)
        {
            mousePos.x = 27;
        }
        if (mousePos.y < -5)
        {
            mousePos.y = -5;
        }
        if (mousePos.y > 15)
        {
            mousePos.y = 15;
        }
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
            RaycastHit2D rayHit = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity, allTilesLayer);
            if (rayHit.collider)
            {
                Destroy(rayHit.collider.gameObject);
            }
            items.SetActive(false);
            shop.SetActive(true);

        }
    }
}
