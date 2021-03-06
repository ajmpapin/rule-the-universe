﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePower : MonoBehaviour {
    SpriteRenderer shipSprite;
    public float fadeTime = 2f;
    float fadeColor;
    public GameObject powerupPrefab;

    public void PowerUp() {
        enabled = true;
    }

    void Update() {
        // get befriended ship sprite
        shipSprite = GetComponentInChildren<SpriteRenderer>();

        // end color for befriended ship sprite
        // shipSprite.color = new Color (1, 1, 1, 0);
        fadeColor = shipSprite.color.a;
        fadeColor -= (1 / fadeTime) * Time.deltaTime;
        shipSprite.color = new Color (1, 1, 1, fadeColor);
        if (fadeColor <= 0) {
            Instantiate(powerupPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
