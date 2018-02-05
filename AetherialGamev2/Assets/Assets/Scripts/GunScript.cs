using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject PlayerBullet;
    public GameObject bulletPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject bullet = (GameObject)Instantiate(PlayerBullet);
            bullet.transform.position = bulletPosition.transform.position;

            Debug.Log("Pressed left click.");
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
        mousePosition.x - transform.position.x,
        mousePosition.y - transform.position.y);

        transform.right = direction;
    }
}
