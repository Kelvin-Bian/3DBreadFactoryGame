﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreValue : MonoBehaviour
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(10, 10);
    }
}
