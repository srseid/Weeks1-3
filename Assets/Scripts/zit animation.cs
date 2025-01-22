using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zitanimation : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0,1)]
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        z = 1;
    }

    // Update is called once per frame
    void Update()
    {
        z += Time.deltaTime;

        if ((z) > 1)
        {
            z = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(z);
    }
}
