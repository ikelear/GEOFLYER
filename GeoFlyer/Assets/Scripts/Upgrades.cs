using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Upgrades : MonoBehaviour
{
    float money;
    float fuel;
    public Text txt;

    void Start()
    {
        money = GlobalController.Instance.money;
        fuel = GlobalController.Instance.fuel;
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
        if(money > 0)
        {
            money = money - 1;
            fuel = fuel + 1000.0f;
            txt.text = money.ToString();
            GlobalController.Instance.money = money;
            GlobalController.Instance.fuel = fuel;
        }
    }
    public void Armor()
    {
        if (money > 0)
        {
            money = money - 1;
            txt.text = money.ToString();
            GlobalController.Instance.money = money;
        }
    }
}
