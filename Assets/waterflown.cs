using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterflown : MonoBehaviour
{
    public int count=0;
    public Text wastedtext;
    // Start is called before the first frame update
    void Start()
    {
        wastedtext=GameObject.Find("Wasted").GetComponent<Text>();
        wastedtext.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        wastedtext.text = count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        count++;
        Destroy(collision.collider.gameObject);
        Debug.Log("Water wasted");
    }
}
