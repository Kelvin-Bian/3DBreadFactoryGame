using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    [SerializeField]
    private GameObject finalObject;
    public bool colliding;
    // Update is called once per frame
    private void Awake()
    {
        colliding = false;
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, Main.groundLayer))
        {
            Vector3 hitPos = new Vector3(Mathf.Round(hit.point.x), hit.point.y, Mathf.Round(hit.point.z));
            transform.position = hitPos;
            //place item
            if (Input.GetMouseButtonDown(0))
            {
                if(!colliding)
                {
                    Instantiate(finalObject, transform.position, transform.rotation);
                    this.gameObject.SetActive(false);
                    Main.inventory.SetActive(true);
                }

            }
        }

        if (Input.GetKeyDown("r"))
        {
            transform.Rotate(Vector3.up, 90f);
        }

    }
}
