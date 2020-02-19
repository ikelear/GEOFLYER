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
            GlobalController.Instance.newScore = true;
            Debug.Log(score);
            SceneManager.LoadScene(sceneName: "StartMenu");
        }
        
    }
}
