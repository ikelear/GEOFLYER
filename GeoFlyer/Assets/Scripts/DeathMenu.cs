using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public Text scoreText;
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
