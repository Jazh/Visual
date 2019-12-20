﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        if(target == null) {
            target = NewBehaviourScript.instance.transform;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = target.position;
        pos.z = -10;
        transform.position = pos;
    }
}
