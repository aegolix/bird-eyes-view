﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
         DestroyObject(other.gameObject);
    }
}
