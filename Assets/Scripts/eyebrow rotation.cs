using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class eyebrowrotation : MonoBehaviour
{
  
    public AnimationCurve curve;
    //ability to change position of eyebrows

    public Transform normal;
    //starting position for eyebrows, making it public to easily apply coordinates in inspector
    public Transform furrow;
    //ending position for eyebrows when mouse is clicked show anger.  why are you bothering her!!


    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //when mouse is clicked, make eyebrows furrow
            transform.position = furrow.position;
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            transform.position = normal.position;
            //when mouse is released, make eyebrows in normal starting position
        }




    }
}
