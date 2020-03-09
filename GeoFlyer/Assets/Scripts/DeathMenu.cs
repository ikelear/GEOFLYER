using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
    public NewHighScore newHighScoreScript;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleEndMenu(float Score)
    {
        gameObject.SetActive(true);
        scoreText.text = ((float)Score).ToString();
        GlobalController.Instance.NewHighScore(Score);
        Debug.Log(GlobalController.Instance.newHighScore);
        if (GlobalController.Instance.newHighScore == true)
        {
            Debug.Log("New Highscore");
            newHighScoreScript.NewHighscore();
            //GlobalController.Instance.newHighScore = false; 
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void ToUpgrade()
    {
        SceneManager.LoadScene("UpgradeMenu");
    }
}
