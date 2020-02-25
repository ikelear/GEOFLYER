using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalController : MonoBehaviour
{

    public static GlobalController Instance;

    public int playerScore;
    public bool newScore = false;
    public int highScore1 = 0, highScore2 = 0, highScore3 = 0, highScore4 = 0, highScore5 = 0, highScore6 = 0, highScore7 = 0, highScore8 = 0, highScore9 = 0, highScore10 = 0, highScore11 = 0, highScore12 = 0, highScore13 = 0, highScore14 = 0, highScore15 = 0;
    public List<int> localHighScores = new List<int>();

    void Awake()
    {

        localHighScores = new List<int> { highScore1, highScore2, highScore3, highScore4, highScore5, highScore6, highScore7, highScore8, highScore9, highScore10, highScore11, highScore12, highScore13, highScore14, highScore15 };

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
        if (newScore == true)
        {
            for (int i = 0; i < localHighScores.Count; i++)
            {
                if (playerScore > localHighScores[i])
                {
                    int spot = i;
                    int oldScore = localHighScores[i];
                    localHighScores[i] = playerScore;

                    for (int a = spot; a < localHighScores.Count - spot; a++)
                    {
                        int nextSpot = localHighScores[a+1];
                        localHighScores[a + 1] = oldScore;
                        oldScore = nextSpot;
                    }
                    newScore = false;
                    break;
                }
                else if (playerScore == localHighScores[i])
                {
                    Debug.Log("Else if called");
                    int spot1 = i;
                    for (int a = spot1; a < localHighScores.Count - spot1; a++)
                    {
                        int nextSpot = localHighScores[a + 1];
                        localHighScores[a + 1] = playerScore;
                        playerScore = nextSpot;
                    }
                }
            }
            newScore = false;
        }
    }
}
