using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // public float maxSpeed = 5f;
    public float rotSpeed = 180f;
    public Sprite mainBackground;
    public Vector3 velocity = new Vector3(0, 0, 0);
    public float accelerationCap = 1.5f;
    public float dragCoefficient = 1f;
    public float brakeDrag = 2f;

    void FixedUpdate() {
        // ROTATE the ship

        // Grab our rotation quaternion
        Quaternion rot = transform.rotation;

        // Grab the Z euler angle
        float z = rot.eulerAngles.z;

        // Change the Z angle based on input
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        // Recreate the quaternion
        rot = Quaternion.Euler(0, 0, z);

        // Feed the quaternion into our rotation
        transform.rotation = rot;

        // ship movement starts here
        Vector3 pos = transform.position;
        // float speed = Input.GetAxis("Vertical") * maxSpeed;
        // Vector3 velocity = rot * new Vector3(0, speed, 0);

        // acceleration from player input
        float shipAcceleration = Input.GetAxis("Vertical") * accelerationCap;
        Vector3 acceleration = new Vector3(0, 0, 0);

        if (shipAcceleration > 0) {
            acceleration = rot * new Vector3(0, shipAcceleration, 0);
            Vector3 drag =
                dragCoefficient * velocity.sqrMagnitude * -velocity.normalized;
            acceleration = acceleration + drag;
        }

        // add drag
        if (shipAcceleration < 0) {
            Vector3 drag =
                brakeDrag * velocity.magnitude * -velocity.normalized;
            acceleration = acceleration + drag;
        }

        // accelerate the ship, apply drag
        velocity += acceleration * Time.deltaTime;
        pos += velocity * Time.deltaTime;

        // TELEPORT player when it leaves background bounds

        if(pos.y >= mainBackground.bounds.max.y) {
            pos.y = pos.y - mainBackground.bounds.size.y;
        }

        if(pos.y <= mainBackground.bounds.min.y) {
            pos.y = pos.y + mainBackground.bounds.size.y;
        }

        if(pos.x >= mainBackground.bounds.max.x) {
            pos.x = pos.x - mainBackground.bounds.size.x;
        }

        if(pos.x <= mainBackground.bounds.min.x) {
            pos.x = pos.x + mainBackground.bounds.size.x;
        }

        transform.position = pos;
    }

    public void StartCombat() {
        enabled = true;
    }
}
