using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveDemo : MonoBehaviour
{
    //AnimationCurve is already a function name, don't name a script it
    public AnimationCurve curve;
    [Range(0,1)] public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if(t>1)
        {
            t = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(t); 
            //no such thing as a world scale
    }
}
