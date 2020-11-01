﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {

        cooldownTimer -= Time.deltaTime;

        if(Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
          // Shoot!
            Debug.Log ("Pew!");
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
