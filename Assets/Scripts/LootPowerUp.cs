using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPowerUp : MonoBehaviour
{

    int powerupAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        Debug.Log ("ADD MUSICAL CUE PLEASE");

        if (entity.tag == "powerup") {
            Destroy(entity.gameObject);

            powerupAmt++;
            Debug.Log ("you have " + powerupAmt + " power up!");
        }
    }
}
