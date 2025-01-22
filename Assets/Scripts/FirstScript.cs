using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.01f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public Spawner thingThatSpawnedMe;
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer.color = Random.ColorHSV();

        if(sprites.Length == 0)
        {

        }
        else
        {
            spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length)];
            spriteRenderer.sortingOrder = -1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        if(screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;



    }
}
