using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;

        //pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        //transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        transform.Rotate(0,0, -Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
    }

}
