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

    private void Start()
    {
        money = 0f;
        txt.text = money.ToString();
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

            StartCoroutine(ExecuteAfterTime(3));
        }
        if(other.transform.tag == "coin")
        {
            Destroy(other.gameObject);
            money = money + 1.0f;
            txt.text = money.ToString();
        }
        


    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
