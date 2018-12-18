﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour {

    public int specialAttackMeter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("collider hit");
        if (other.gameObject.CompareTag("collectible"))
        {
            other.gameObject.SetActive(false);
            specialAttackMeter++;
            print(specialAttackMeter);
        }
    }
}
