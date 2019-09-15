using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //mouse is fire  Jump is up button
            {
            SpawnPin();

        }
    }

        void SpawnPin()
        {
            Instantiate(pinPrefab, transform.position, transform.rotation);
        }
    
}
