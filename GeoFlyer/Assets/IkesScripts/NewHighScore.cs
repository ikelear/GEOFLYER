using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHighScore : MonoBehaviour
{

    public InputField name;
    float currentScore;

    string playerName;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void NewHighscore()
    {
        gameObject.SetActive(true);
    }

    public void HighScoreName()
    {
        playerName = name.text;
        currentScore = GlobalController.Instance.latestScore;
        GlobalController.Instance.name = playerName;
        GlobalController.Instance.NewHighScore(currentScore);
    }
}
