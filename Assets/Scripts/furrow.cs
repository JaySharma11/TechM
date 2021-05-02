using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furrow : MonoBehaviour
{
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
        main.currenttool = "furrow";
        Debug.Log(main.currenttool);
    }

    public void Shoveldig() 
    {
        if(pause.GameIsPaused == false)
        {
            main.currenttool = "shovel";
            Debug.Log(main.currenttool);
        }
    }
}
