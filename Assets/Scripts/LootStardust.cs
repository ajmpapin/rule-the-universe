using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootStardust : MonoBehaviour {
    public Text stardustCount;
    int stardustAmt = 0;

    void OnTriggerEnter2D(Collider2D entity) {
        if (entity.tag == "loot") {
            Debug.Log ("Ka-ching!");
            Destroy(entity.gameObject);
            stardustAmt++;
            Debug.Log ("stardust = " + stardustAmt);
            stardustCount.text = "Stardust Collected: " + stardustAmt;
        }
    }

    public void BuyFriendship(int fee) {
        if (stardustAmt <= 0) {
            // don't take stardust, player is broke :(
        } else {
            Debug.Log ("stardust = " + stardustAmt);
            stardustAmt = stardustAmt - fee;
            stardustCount.text = "Stardust Collected: " + stardustAmt;
        }
    }
}
