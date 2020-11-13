using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootStardust : MonoBehaviour
{

    public Text stardustCount;

    int stardustAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        Debug.Log ("Ka-ching!");

        if (entity.tag == "loot") {
            Destroy(entity.gameObject);

            stardustAmt++;
            Debug.Log ("stardust = " + stardustAmt);

            stardustCount.text = "Stardust Collected: " + stardustAmt;
        }
    }
}
