using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float jumpForce;
    public float physicModifier;
    private Rigidbody playerRb;
    public bool isGround = true;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= physicModifier;


    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&&isGround){
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isGround = false;
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }
}
