using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager2 : MonoBehaviour
{
    public int keyCount2;
    public Text keyText2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keyText2.text = keyCount2.ToString("1") + "/3";
    }
}