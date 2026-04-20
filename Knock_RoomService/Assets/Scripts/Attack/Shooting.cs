using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject rf_bulletPreFab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot ()
    {
        //all of the shooting logic is here
        Instantiate(rf_bulletPreFab, firePoint.position, firePoint.rotation);
    }
}
