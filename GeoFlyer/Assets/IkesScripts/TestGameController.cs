using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestGameController : MonoBehaviour
{

    int score;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            score = Random.Range(0, 100);
            GlobalController.Instance.playerScore = score;
            GlobalController.Instance.playerScore = 1;
            Debug.Log(score);
            SceneManager.LoadScene(sceneName: "StartMenu");
        }
        
    }
}
