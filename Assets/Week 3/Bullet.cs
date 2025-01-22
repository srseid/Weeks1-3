using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public bool hasBeenFired = false;
    void Update()
    {
        if(hasBeenFired == true)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
        
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        //transform.up knows about the rotation of the triangle
        //Vector3.up knows the world's up

        //transform.Translate(transform.up * speed * Time.deltaTime); 
        //does smth similar, just depends what u want
    }
}
