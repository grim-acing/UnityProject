using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    public int jumpForce;
    bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)){
        if (Input.GetButtonDown("Jump") && canJump == true){ //space bar
        
            rb.AddForce(transform.up * jumpForce);
            Debug.Log("it jumped?");
            canJump = false;
        }
    }

    void OnCollisionEnter(Collision player){
        if(player.gameObject.layer == 8){ //ground layer
        canJump = true;

        }
    }
}
