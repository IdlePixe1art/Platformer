using UnityEngine;
using System.Collections;

public class Respawning : MonoBehaviour
{
    public Transform spawnPoint;
    public float minHeightForDeath;
    public GameObject obj_Player;

    void Start()
    {

    }
   
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = spawnPoint.position;
    }
}
