using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    public GameObject winMenu;

    // if all ships are gone

    void Update() {
        GameObject alienA = GameObject.Find("ShipAlienA1");
        GameObject alienB = GameObject.Find("ShipAlienB1");
        GameObject alienC = GameObject.Find("ShipAlienC1");

        if ((alienA == null)
            && (alienB == null)
            && (alienC == null)) {
            winMenu.SetActive(true);
        }
    }
}
