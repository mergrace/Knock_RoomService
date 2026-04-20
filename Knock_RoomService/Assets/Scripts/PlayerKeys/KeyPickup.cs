using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public KeyCounter cm;
    private void OnTiggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            cm.coinAmount++;
        }
    }
}
