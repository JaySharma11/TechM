using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placing : MonoBehaviour
{
    public Mesh check_dam;
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
            if(pause.GameIsPaused == false)
            {
                Debug.Log("Furrow placed");
                main.selectedtool = "topmid";
                GameObject Score = GameObject.Find(main.selectedtool);
                MeshFilter currmesh = Score.GetComponent<MeshFilter>();
                currmesh.sharedMesh = check_dam;
                gameObject.GetComponent<Transform>().localScale = new Vector3(10,10,10);
                var boxCollider = GetComponent<BoxCollider>();
                boxCollider.size = new Vector3(10,5,2);
            }
        }
    } 
}