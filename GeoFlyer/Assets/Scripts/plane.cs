using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class plane : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosiondetector;
    public GameObject coin;
    public Text txt;
    float money;
    public DeathMenu deathMenu;

    
    public Text txt2;
    float meterscore;
    public float kmscore;
    float pointIncreasePerSecond;
    float fuel;

    public FuelBar fuelBar;


    private void Start()
    {
        money = GlobalController.Instance.money;
        fuel = GlobalController.Instance.fuel;
       
        txt.text = money.ToString();
        meterscore = 0f;
        kmscore = 0f;
        pointIncreasePerSecond = 200.0f;
        fuelBar.SetMaxFuel(fuel);
        
    }

    private void Update()
    {
        fuel = fuel - 1;
        print(fuel);
        if (fuel == 0)
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            transform.position = new Vector3(0, -20, 0);
            explosiondetector.SetActive(false);
            deathMenu.ToggleEndMenu(kmscore);
        }
        if (explosiondetector.activeSelf)
        {
            meterscore += pointIncreasePerSecond * Time.deltaTime;
            kmscore = meterscore / 1000.0f;
            txt2.text = kmscore.ToString();

        }
        fuelBar.SetFuel(fuel);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "enemy")
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            transform.position = new Vector3(0, -20, 0);
            explosiondetector.SetActive(false);
            deathMenu.ToggleEndMenu(kmscore);

        }
        if(other.transform.tag == "coin")
        {
            Destroy(other.gameObject);
            money = money + 1.0f;
            GlobalController.Instance.money = money;
            txt.text = money.ToString();
        }
        


    }
    
}
