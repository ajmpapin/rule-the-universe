using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageHandler : MonoBehaviour {
    public int health;
    public int healthPoss;
    public Image[] healthShips;
    public Sprite fullShip;
    public Sprite emptyShip;
    public Sprite bonusShip;

    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;
    public bool dropsLoot;
    public GameObject stardustPrefab;

    void Start() {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D(Collider2D entity) {
        if (entity.tag == "loot" || entity.tag.StartsWith("powerup")) {
            // do nothing
        } else {
            health--;
            invulnTimer = invulnPeriod;
            gameObject.layer = 10;
        }
    }

    void Update() {

        if (health > healthPoss) {
            health = healthPoss;
        }
        for (int i = 0; i < healthShips.Length; i++) {
            if (i < health) {
                healthShips[i].sprite = fullShip;
            } else {
                healthShips[i].sprite = emptyShip;
            }

            if (i < healthPoss) {
                healthShips[i].enabled = true;
            } else {
                healthShips[i].enabled = false;
            }
        }

        if (health == 4) {
            healthShips[3].sprite = bonusShip;
            healthShips[3].enabled = true;
        }

        invulnTimer -= Time.deltaTime;
        if (invulnTimer <= 0) {
            gameObject.layer = correctLayer;
        }

        if (health <= 0) {
            Die();
        }
    }

    void Die() {
        if (dropsLoot == true) {
            Debug.Log ("Twinkle...");
            Instantiate(stardustPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}
