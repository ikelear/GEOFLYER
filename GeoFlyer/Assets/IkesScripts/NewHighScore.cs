using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighScore : MonoBehaviour
{
    
    

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void NewHighscore()
    {
        Debug.Log("Hi");
        gameObject.SetActive(true);
    }
}
