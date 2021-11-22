using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewSection : MonoBehaviour
{
    // how far away the other platform spawns
    public float SectionSpawnDistance = 0;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("player"))
        {
            //instantiate add (x = ssd, y = 0, z = 0)
        }
    }
}