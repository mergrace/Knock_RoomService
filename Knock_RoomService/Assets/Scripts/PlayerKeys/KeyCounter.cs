using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{
    public float coinAmount;
    public Text TextOfCoin;
    private void Update()
    {
        TextOfCoin.text = coinAmount.ToString();
    }
}
