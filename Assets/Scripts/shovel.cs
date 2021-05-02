using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovel : MonoBehaviour
{
   public Terrain myTerrain;
    int xResolution;
    int zResolution;
    float[,] heights;
    // Start is called before the first frame update
    void Start()
    {
        xResolution = myTerrain.terrainData.heightmapResolution;
        zResolution = myTerrain.terrainData.heightmapResolution;
        heights = myTerrain.terrainData.GetHeights(0,0,xResolution,zResolution);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pause.GameIsPaused == false)
        {
            if(main.currenttool == "shovel")
            {
                if(Input.GetMouseButton(0))
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if(Physics.Raycast(ray, out hit))
                    {
                        lowerTerrain(hit.point);
                    }
                }
            }
        }
    }

    private void lowerTerrain(Vector3 point)
    {
        int terX =(int)((point.x / myTerrain.terrainData.size.x) * xResolution);
        int terZ =(int)((point.z / myTerrain.terrainData.size.z) * zResolution);
        float y = heights[terX,terZ];
        y -= 0.005f;
        float[,] height = new float[1,1];
        height[0,0] = y;
        heights[terX,terZ] = y;
        for(int i=-2;i<2;i++)
        {
            for(int j=-2;j<2;j++)
            {
                int c=(int) Mathf.Sqrt(4-(i*i));
                myTerrain.terrainData.SetHeights(terX+c, terZ+i-130, height); 
            }        
        }
    }
}
