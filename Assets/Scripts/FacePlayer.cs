using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {
    public float rotSpeed = 90f;
    Transform player;

    void Update() {
        if (player == null) {
            // find the player's shipBoundaryRadius
            GameObject playerShip = GameObject.Find ("PlayerShip");

            if (playerShip != null) {
                player = playerShip.transform;
            }
        }

        // At this point, player is found or player doesn't exist right now
        if (player == null) {
            return; // try again next FramePressState
        }

        // Here we know a player exists
        // Turn to face PlayerLoop
        Vector3 dir = player.position - transform.position;
        dir.Normalize();
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            desiredRot,
            rotSpeed * Time.deltaTime
        );
    }
}
