using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BulletType;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;

    // ?? Different bullet prefabs
    public GameObject rf_BulletPrefab;
    public GameObject pl_BulletPrefab;
    public GameObject kf_BulletPrefab;

    // ?? Current ammo
    private AmmoType currentAmmo = AmmoType.RottenFood;

    // ?? UI highlight images (the bigger ones)
    public GameObject rf_Highlight;
    public GameObject pl_Highlight;
    public GameObject kf_Highlight;

    void Update()
    {
        HandleInput();
        UpdateUI();
    }

    void HandleInput()
    {
        // ?? SWITCHING
        if (Input.GetKeyDown(KeyCode.Alpha1))
            currentAmmo = AmmoType.RottenFood;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            currentAmmo = AmmoType.Plates;

        if (Input.GetKeyDown(KeyCode.Alpha3))
            currentAmmo = AmmoType.Knives;

        // ?? SHOOT
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletToSpawn = null;

        switch (currentAmmo)
        {
            case AmmoType.RottenFood:
                bulletToSpawn = rf_BulletPrefab;
                break;

            case AmmoType.Plates:
                bulletToSpawn = pl_BulletPrefab;
                break;

            case AmmoType.Knives:
                bulletToSpawn = kf_BulletPrefab;
                break;
        }

        Instantiate(bulletToSpawn, firePoint.position, firePoint.rotation);
    }

    void UpdateUI()
    {
        // Turn all OFF first
        rf_Highlight.SetActive(false);
        pl_Highlight.SetActive(false);
        kf_Highlight.SetActive(false);

        // Turn ON selected one
        switch (currentAmmo)
        {
            case AmmoType.RottenFood:
                rf_Highlight.SetActive(true);
                break;

            case AmmoType.Plates:
                pl_Highlight.SetActive(true);
                break;

            case AmmoType.Knives:
                kf_Highlight.SetActive(true);
                break;
        }
    }

}