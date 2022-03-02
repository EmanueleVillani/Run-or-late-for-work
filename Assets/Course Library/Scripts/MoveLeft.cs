using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 25;
    public PlayerController player;
    public GameManager gm;
   
   

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        if(transform.position.x < -3 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
           
            gm.scoreInt++;
        }
       
    }
}
