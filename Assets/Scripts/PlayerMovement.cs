using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    public Sprite mainBackground;

    // float shipBoundaryRadius = 0.5f;

    // Update is called once per frame
    void Update()
    {
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


        // MOVE the ship

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        pos += rot * velocity;

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

    public void StartCombat()
    {
        enabled = true;
    }
}
