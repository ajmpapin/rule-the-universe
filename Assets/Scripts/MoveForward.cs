using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    public float maxSpeed = 10f;

    public void StartCombat() {
        // Debug.Log("ATTACKING NOW");
        enabled = true;
    }

    void Update() {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;
    }
}
