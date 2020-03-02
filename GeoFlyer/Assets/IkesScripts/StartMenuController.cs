using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void GotoLeaderBoard()
    {
        SceneManager.LoadScene(sceneName: "LeaderBoard");
    }

    public void GotoStartMenu()
    {
        SceneManager.LoadScene(sceneName: "StartMenu");
    }

    public void GotoGame()
    {
        SceneManager.LoadScene(sceneName: "SampleScene");
    }
}
