using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //public GameObject PlayerBullet;
    //public GameObject bulletPosition;
    public float speed;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        //movment of the player 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
}
