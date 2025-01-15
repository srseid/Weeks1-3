using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    //lerp is already a function name, don't name a script Lerp
    public AnimationCurve curve; 
    [Range(0f,1f)] public float t;

    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // could be Vector2 pos = new Vector2(Mathf.Lerp(-4, 5, t), 0); with transform.position = pos;
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
