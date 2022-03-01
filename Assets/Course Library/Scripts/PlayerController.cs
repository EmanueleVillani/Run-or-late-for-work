using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isGrond = true;
    public float move;

    void Start()
    {
        
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&&isGrond)
        {
            playerRb.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isGrond = false;
        }

      
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrond = true;
    }
}
