using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)) { 
            transform.Translate(0, 0, -Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);
            transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        }
    }
}
