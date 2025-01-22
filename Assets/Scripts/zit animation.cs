using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class zitanimation : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0.5f,1.25f)]
    public float z;
    public float speed =1;
    // Start is called before the first frame update
    void Start()
    {
        z = 0.75f;
    }

    // Update is called once per frame
    void Update()
    {
        z += Time.deltaTime;

        if ((z) > 1.25f)
        {
            z = 0.5f;
        }

        transform.localScale = Vector2.one * curve.Evaluate(z);

        if(Input.GetMouseButtonDown(0))
        {
            speed = 12;
        }
        else
        {
            speed = 1;
        }
    }
}
