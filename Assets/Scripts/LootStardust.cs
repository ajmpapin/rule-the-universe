using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootStardust : MonoBehaviour
{

    int stardustAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        Debug.Log ("Ka-ching!");

        if (entity.tag == "loot") {
            Destroy(entity.gameObject);

            stardustAmt++;
            Debug.Log ("stardust = " + stardustAmt);
        }
    }
}
