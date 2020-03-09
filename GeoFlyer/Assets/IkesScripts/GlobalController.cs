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
    public List<float> localHighScores = new List<float>();
    public float money;
    

    void Awake()
    {

        localHighScores = new List<float> { highScore1, highScore2, highScore3, highScore4, highScore5, highScore6, highScore7, highScore8, highScore9, highScore10, highScore11, highScore12, highScore13, highScore14, highScore15 };

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
                localHighScores[i] = playerScore;
                newHighScore = true;

                for (int a = i; a < localHighScores.Count - i; a++)
                {
                    float olderScore = localHighScores[a + 1];
                    localHighScores[a + 1] = oldScore;
                    oldScore = olderScore;
                }

                break;
            }


        }
    }
}
