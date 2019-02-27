﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] Transform RespawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
            if (collision.transform.CompareTag("Player"))
            {

                collision.transform.position = RespawnPoint.position;
            }
        }
    }
}
