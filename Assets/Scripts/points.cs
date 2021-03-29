using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public Text thisText;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
        thisText = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void addscore()
    {
        score += 100;
        thisText.text = "" + score;
    }

    public void subtractscore()
    {
        score -= 10;
        thisText.text = "" + score;
    }
}
