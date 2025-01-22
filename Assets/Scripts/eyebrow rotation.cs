using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class eyebrowrotation : MonoBehaviour
{
    [Range(0,1)] public float e;
    public AnimationCurve curve;

    
    public Transform normal;
    public Transform furrow;

    

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(zit))
        {
            //transform.position = Vector2.Lerp(normal.position, furrow.position, curve.Evaluate(e));
            transform.position = furrow.position;
        }
        else
        {
            //transform.position = normal.position;
        }
        


        
    }
}
