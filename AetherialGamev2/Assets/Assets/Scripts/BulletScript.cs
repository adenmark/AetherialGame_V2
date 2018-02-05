using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public float speed;

    //public int speed = 300; //This value can be modified to change the speed
    private Rigidbody2D body;



    void Start()
    {

        GameObject player = GameObject.Find("BulletSpawn");

        gameObject.transform.position = player.transform.position;

        body = GetComponent<Rigidbody2D>();

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - sp).normalized;

        body.AddForce(dir * speed, ForceMode2D.Impulse);
        //body.velocity = transform.forward * speed;
    }

}

