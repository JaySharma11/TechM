using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    public static bool startrain = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void begin()
    {
        if(pause.GameIsPaused == false)
        {
            startrain = true;
        }
    }
}
