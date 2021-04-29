using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateminus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateminus()
    {
        GameObject gameObj = GameObject.Find(main.selectedtool);

        gameObj.transform.eulerAngles = new Vector3(
        gameObj.transform.eulerAngles.x,
        gameObj.transform.eulerAngles.y - 10,
        gameObj.transform.eulerAngles.z
    );
    }
}
