using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyemovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouse - transform.position;
        transform.up = direction;
        //I know this is the code you taught in class but from what I've learned in the readings and the classes, there isn't another way to have objects move with the mouse
        //I did use this code for objects that have no SpriteRenderer and made the pupil a child. so that the pupil's of the eyes can follow the mouse while being restricted to the eyeball
    
}
}
