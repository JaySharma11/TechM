using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
   // Start is called before the first frame update
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private float zoomStep,  minCamSize , maxCamSize;
    //[Serializable]
    //private SpriteRenderer mapRenderer;

    private float mapMinX , mapMaxX , mapMinY, mApMaxY ; 

    private void Awake() {
       mapMinX = -100;//mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
       mapMaxX = 100;//mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;
       mapMinY = -100;//mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
       mApMaxY = 100;//mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }

    private Vector3 dragOrigin;
    private void Update()
    {
        PanCamera();
    }
    private void PanCamera()
    {
        //save position of mouse
        if(Input.GetMouseButtonDown(0))
        dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
         if(Input.GetMouseButton(0))
         {
             Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
             //print("origin"+dragOrigin + "newPosition" + cam.ScreenToWorldPoint(Input.mousePosition)+ " = difference" + difference);
             cam.transform.position = ClampCamera(cam.transform.position + difference); 
             //cam.transform.position ;
         }

    }
    // public void ZoomIn()
    // {
    //    float newSize = cam.orthographicSize + zoomStep ; 
    //    cam.orthographicSize = Mathf.Clamp(newSize , minCamSize, maxCamSize); 
    //    cam.transform.position = ClampCamera(cam.transform.position);
    // }

    // public void ZoomOut()
    // {
    //    float newSize = cam.orthographicSize - zoomStep ; 
    //    cam.orthographicSize = Mathf.Clamp(newSize , minCamSize, maxCamSize); 
    //    cam.transform.position = ClampCamera(cam.transform.position);

    // }

    private Vector3 ClampCamera(Vector3 targetPosition){

        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camWidth;
        float maxY = mApMaxY - camWidth;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);
        return new Vector3( newX, newY , targetPosition.z);

    }

}