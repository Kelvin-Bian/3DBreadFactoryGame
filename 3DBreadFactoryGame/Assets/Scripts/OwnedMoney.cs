﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OwnedMoney : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Money: " + Main.money.ToString("0.00");
    }
}
