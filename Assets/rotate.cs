using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    new Quaternion rort;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnMouseDown()
        {
            GetComponent<BoxCollider2D>().transform.rotation = rort;
            Debug.Log("Selected"); 
        }
    }
}
