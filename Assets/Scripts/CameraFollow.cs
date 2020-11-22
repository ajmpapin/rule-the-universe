﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform myTarget;
    // Update is called once per frame
    void LateUpdate()
    {
        if(myTarget != null) {
          Vector3 targPos = myTarget.position;
          targPos.z = transform.position.z;
          //Vector3.Lerp()
          transform.position = targPos;
        }
    }
}
