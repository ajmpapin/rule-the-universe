using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPowerUp : MonoBehaviour {
    int powerupAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        if (entity.tag == "powerup") {
            Debug.Log ("ADD MUSICAL CUE PLEASE");
            Destroy(entity.gameObject);
            powerupAmt++;
            Debug.Log ("you have " + powerupAmt + " power up(s)!");
        }
    }
}
