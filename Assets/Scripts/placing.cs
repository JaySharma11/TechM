using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placing : MonoBehaviour
{
    public Sprite furrow1;
    BoxCollider2D m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(main.currenttool == "furrow")
        {
            Debug.Log("Furrow picked");
            GetComponent<SpriteRenderer>().sprite = furrow1;
            transform.rotation = Quaternion.Euler(Vector3.forward * -25);
            m_Collider = GetComponent<BoxCollider2D>();
            m_Collider.offset =  new Vector2(0.04244328f,0.007222198f);
            m_Collider.size =  new Vector2(2.423902f,0.4296626f);
        }
    } 
}