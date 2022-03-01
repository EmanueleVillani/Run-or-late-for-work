using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject  obstaclePref;
    private Vector3 newPos = new Vector3(25, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2.5f;
   
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
         
        Instantiate(obstaclePref, newPos, obstaclePref.transform.rotation);
    }
}
