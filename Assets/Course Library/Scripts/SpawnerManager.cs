using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    private PlayerController player;
    public GameObject [] obstaclePref;
    private Vector3 newPos = new Vector3(25, 0, 0);
    public float startDelay = 4;
    public float repeatRate = 4.5f;

   
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (!player.gameOver)
        {
            int indexPrefabs = Random.Range(0, 3);
            Instantiate(obstaclePref[indexPrefabs], newPos, obstaclePref[indexPrefabs].transform.rotation);
        }
       
    }
}
