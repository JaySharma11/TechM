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

    public void Selection() 
    {
        if(pause.GameIsPaused == false)
        {
            main.currenttool = "furrow";
            Debug.Log(main.currenttool);
        }
    }
}
