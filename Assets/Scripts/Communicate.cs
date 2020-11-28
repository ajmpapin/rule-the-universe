using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communicate : MonoBehaviour {
    public Fungus.Flowchart firstContact;
    public float distanceThreshold = 5.0f;

    void Update() {
        GameObject playerShip = GameObject.Find ("PlayerShip");

        Vector3 playerPosition = playerShip.transform.position;
        // Debug.Log (go.transform.position); // playership position

        Vector3 alienPosition = transform.position;
        // Debug.Log (transform.position); // alien ship position

        float playerAlienDistance = Vector3.Distance(playerPosition, alienPosition);
        // Debug.Log (playerAlienDistance);

        if (playerAlienDistance <= distanceThreshold) {
            // ship faces playership, player freezes and can't shoot
            GetComponent<FacePlayer>().enabled = true;
            playerShip.GetComponent<PlayerMovement>().enabled = false;
            playerShip.GetComponent<PlayerShooting>().enabled = false;

            // execute Fungus DialogueFlowchart
            firstContact.ExecuteBlock("FirstContact");

            // ExecuteBlock(string FirstContact);
            Debug.Log ("In the zone!");

            // kill this Communicate script
            Destroy(this);
        }
    }
}
