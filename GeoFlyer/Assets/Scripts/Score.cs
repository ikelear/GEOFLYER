using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject explosiondetector;
    public Text txt;
    float meterscore;
    public float kmscore;
    float pointIncreasePerSecond;
    
    
    void Start()
    {
        meterscore = 0f;
        kmscore = 0f;
        pointIncreasePerSecond = 200.0f;
    }

   
    void Update()
    {
        if(explosiondetector.activeSelf)
        {
            meterscore += pointIncreasePerSecond * Time.deltaTime;
            kmscore = meterscore / 1000.0f;
            txt.text = kmscore.ToString();
            
        }
        
        

    }
}
