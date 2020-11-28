using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {
    public int health = 1;
    public float invulnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;
    public bool dropsLoot;
    public GameObject stardustPrefab;

    void Start() {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D(Collider2D entity) {
        if (entity.tag == "loot" || entity.tag == "powerup") {
            // do nothing
        } else {
            health--;
            invulnTimer = invulnPeriod;
            gameObject.layer = 10;
        }
    }

    void Update() {
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
