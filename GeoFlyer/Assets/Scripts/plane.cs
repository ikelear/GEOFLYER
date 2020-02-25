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


    private void Start()
    {
        money = 0f;
        txt.text = money.ToString();
        meterscore = 0f;
        kmscore = 0f;
        pointIncreasePerSecond = 200.0f;
    }

    private void Update()
    {
        if (explosiondetector.activeSelf)
        {
            meterscore += pointIncreasePerSecond * Time.deltaTime;
            kmscore = meterscore / 1000.0f;
            txt2.text = kmscore.ToString();

        }
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

            //StartCoroutine(ExecuteAfterTime(3));
        }
        if(other.transform.tag == "coin")
        {
            Destroy(other.gameObject);
            money = money + 1.0f;
            txt.text = money.ToString();
        }
        


    }
    //IEnumerator ExecuteAfterTime(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //    this.gameObject.SetActive(false);
    //    SceneManager.LoadScene("SampleScene");
    //}

    //ctrl k to comment lots of code
    //ctrl u to uncomment
}
