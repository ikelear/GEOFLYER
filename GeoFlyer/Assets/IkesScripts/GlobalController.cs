using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalController : MonoBehaviour
{

    public static GlobalController Instance;


    public bool newHighScore = false;
    public float highScore1 = 0, highScore2 = 0, highScore3 = 0, highScore4 = 0, highScore5 = 0, highScore6 = 0, highScore7 = 0, highScore8 = 0, highScore9 = 0, highScore10 = 0, highScore11 = 0, highScore12 = 0, highScore13 = 0, highScore14 = 0, highScore15 = 0;
    public string name1 = "", name2 = "", name3 = "", name4 = "", name5 = "", name6 = "", name7 = "", name8 = "", name9 = "", name10 = "", name11 = "", name12 = "", name13 = "", name14 = "", name15 = "";
    public List<float> localHighScores = new List<float>();
    public List<string> localHighScoresNames = new List<string>();
    public float money;
    public new string name;
    public float latestScore;

    void Awake()
    {

        localHighScores = new List<float> { highScore1, highScore2, highScore3, highScore4, highScore5, highScore6, highScore7, highScore8, highScore9, highScore10, highScore11, highScore12, highScore13, highScore14, highScore15 };
        localHighScoresNames = new List<string> { name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15 };

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }


                
    }

    private void Update()
    {
        //Debug.Log(newScore);
        /*if (newScore == true)
        {
            Debug.Log("NEW SCORE LOOP");
            for (int i = 0; i < localHighScores.Count; i++)
            {
                if (playerScore > localHighScores[i])
                {
                    //Debug.Log(localHighScores[i]);
                    int spot = i;
                    int oldScore = localHighScores[i];
                    localHighScores[i] = playerScore;

                    for (int a = i; a < localHighScores.Count - i; a++)
                    {
                        float olderScore = localHighScores[a+1];
                        localHighScores[a + 1] = oldScore;
                        oldScore = olderScore;
                    }
                    newScore = false;
                    break;
                }
                
              
            }
            newScore = false;
            
        }/*/
    }

    public void NewHighScore(float playerScore)
    {
        Debug.Log("NEW SCORE LOOP");
        for (int i = 0; i < localHighScores.Count; i++)
        {
            if (playerScore > localHighScores[i])
            {
                Debug.Log("OH THAT NUMBER BIG");
                float oldScore = localHighScores[i];
                string oldName = localHighScoresNames[i];
                localHighScores[i] = playerScore;
                localHighScoresNames[i] = name;

                for (int a = i; a < localHighScores.Count - i; a++)
                {
                    if (a != localHighScores.Count -1)
                    {
                        float olderScore = localHighScores[a + 1];
                        string olderName = localHighScoresNames[a + 1];
                        localHighScores[a + 1] = oldScore;
                        localHighScoresNames[a + 1] = oldName;
                        oldScore = olderScore;
                        oldName = olderName; 
                    }
                }

                break;
            }


        }
    }

    public void NewHighScoreCheck(float playerScore)
    {
        for (int i = 0; i < localHighScores.Count; i++)
        {
            if (playerScore > localHighScores[i])
            {
                newHighScore = true;
            }
        }
    }
}
