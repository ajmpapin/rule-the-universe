using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPowerUp : MonoBehaviour {
    int powerupAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        if (entity.tag == "powerup1") { // fire faster
            Debug.Log ("ADD MUSICAL CUE PLEASE");
            Destroy(entity.gameObject);
            GetComponent<PlayerShooting>().fireDelay = 0.25f;
            Debug.Log ("you have increased rate of fire!");
        }

        if (entity.tag == "powerup2") { // add health
            Debug.Log ("ADD MUSICAL CUE PLEASE");
            Destroy(entity.gameObject);
            GetComponent<DamageHandler>().healthPoss = 4;
            GetComponent<DamageHandler>().health = 4;
            Debug.Log ("you have +1 health!");
        }

        if (entity.tag == "powerup3") { // accelerate more
            Debug.Log ("ADD MUSICAL CUE PLEASE");
            Destroy(entity.gameObject);
            GetComponent<PlayerMovement>().accelerationCap = 8;
            Debug.Log ("you can fly faster!");
        }
    }
}
