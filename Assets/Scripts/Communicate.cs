using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communicate : MonoBehaviour
{

    public float distanceThreshold = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find ("PlayerShip");

        Vector3 playerPosition = go.transform.position;
        // Debug.Log (go.transform.position); // playership position

        Vector3 alienPosition = transform.position;
        // Debug.Log (transform.position); // alien ship position

        float playerAlienDistance = Vector3.Distance(playerPosition, alienPosition);
        // Debug.Log (playerAlienDistance);

        if(playerAlienDistance <= distanceThreshold) {
            Debug.Log ("In the zone!");
        }
    }
}
