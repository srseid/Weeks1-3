using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class zitanimation : MonoBehaviour
{
    public AnimationCurve curve;
    //have better range of animation, beating pattern
    [Range(0.5f,1.25f)]
    //size of how big and small the zit can be
    public float z;
    //size of zit
    public float speed =1;
    //speed of beating zit

    // Start is called before the first frame update
    void Start()
    {
        z = 0.75f;
        //initial size of zit
    }

    // Update is called once per frame
    void Update()
    {
        z += Time.deltaTime;
        //make size change by time
        if ((z) > 1.25f)
        {
            z = 0.5f;
            //if the zit gets this big, change it to this size
        }

        transform.localScale = Vector2.one * curve.Evaluate(z);
        //have size of the pimple relate to the animation curve
        if (Input.GetMouseButtonDown(0))
        {
            speed = 12;
            //if mouse is clicked, the animation is sped up
        }
        else
        {
            speed = 1;
        }
    }
}
