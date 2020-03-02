using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Upgrades : MonoBehaviour
{
    float money;
    public Text txt;

    void Start()
    {
        money = GlobalController.Instance.money;
        txt.text = money.ToString();
    }

  
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Fuel()
    {
        money = money - 1;
    }
    public void Armor()
    {
        money = money - 1;
    }
}
