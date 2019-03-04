using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Rigidbody playerBody;
    [SerializeField]
    private float jumpForce = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        playerBody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, playerBody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
    
        if(Input.GetButtonDown("Jump"))
        {
            playerBody.velocity = new Vector3(playerBody.velocity.x, jumpForce, playerBody.velocity.z);
        }
    }
}
