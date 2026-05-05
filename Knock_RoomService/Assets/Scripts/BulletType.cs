using System.Collections.Generic;
using UnityEngine;

public class BulletType : MonoBehaviour
{
    public enum AmmoType {RottenFood, Plates, Knives}
    public AmmoType currentAmmoType = AmmoType.RottenFood;

    // UI or debugging to show current type
    [SerializeField] private string currentAmmoName;

    void Update()
    {
        // Switch ammo using number keys 1, 2, 3
        if (Input.GetKeyDown(KeyCode.Alpha1)) SetAmmoType(AmmoType.RottenFood);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SetAmmoType(AmmoType.Plates);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SetAmmoType(AmmoType.Knives);

        currentAmmoName = currentAmmoType.ToString();
    }

    void SetAmmoType(AmmoType newType)
    {
        currentAmmoType = newType;
        Debug.Log("Ammo Switched to: " + currentAmmoType);
        // Optional: Play sound or update UI here
    }
}
