using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class absorb : MonoBehaviour
{
    int c=0;
    int h=0;
    SpriteRenderer sprite;
    points game;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(c>1 && c<3)
        {
             sprite.color = new Color (0, 1, 1, 1);
        }
        else if(c>3)
        {
            sprite.color = new Color (0, 0, 1, 1);
            
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        c++;
        Destroy(collision.collider.gameObject);
        if(c!=h && c<4)
        {
            game = FindObjectOfType<points>();
            game.addscore();
            h++;
        }
        else if(c>3)
        {
            game = FindObjectOfType<points>();
            game.subtractscore();
        }
        
    }
}
