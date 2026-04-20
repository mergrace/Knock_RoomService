using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManger : MonoBehaviour
{
    [SerializeField] private GameObject slotsHolder;

    public List<ItemClass> item = new List<ItemClass>();
}
