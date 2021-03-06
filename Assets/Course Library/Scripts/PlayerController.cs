using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem ParticlePlayer;
    public ParticleSystem explosionePlayer;
    private Animator playerAnim;
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isGrond = true;
    public float move;
    public bool gameOver;
    public GameObject button;
    
   

    void Start()
    {
       
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
       


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Mouse0)&&isGrond&&!gameOver)
        {
            playerAnim.SetTrigger("Jump_trig");
            playerAnim.SetInteger("DeathType_int",1);
            
            playerRb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isGrond = false;
            ParticlePlayer.Stop();
        }

      
    }
    private void OnCollisionEnter(Collision collision)
    {
        ParticlePlayer.Stop();
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrond = true;
            ParticlePlayer.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;
            explosionePlayer.Play();
            Debug.Log("GameOver");
            playerAnim.SetBool("Death_b", true);
            button.SetActive(true);
        }
       
    }
}
