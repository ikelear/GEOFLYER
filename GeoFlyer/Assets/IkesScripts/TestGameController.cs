using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestGameController : MonoBehaviour
{

    float score;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            score = Random.Range(0, 100);
            //GlobalController.Instance.newScore = true;
            Debug.Log("Score is: " + score);
            SceneManager.LoadScene(sceneName: "StartMenu");
            GlobalController.Instance.NewHighScore(score);
        }
        
    }
}
