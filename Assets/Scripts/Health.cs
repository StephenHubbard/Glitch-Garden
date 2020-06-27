﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if(!deathVFX)
        {
            return;
        }

        float horizontalInput = Input.GetAxis("Horizontal");

        GameObject deathVFXObject = Instantiate(deathVFX, transform.position + (transform.right * -0.6f) + (transform.up * 0f), transform.rotation);
        Destroy(deathVFXObject, 2f);

    }
}
