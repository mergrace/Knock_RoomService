using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager3 : MonoBehaviour
{
    public int keyCount3;
    public Text keyText3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyCount3 = 2;
    }

    // Update is called once per frame
    void Update()
    {
        keyText3.text = keyCount3.ToString(keyCount3 + "/3");
    }
}