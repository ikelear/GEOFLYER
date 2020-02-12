using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hit detected");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        transform.position = new Vector3(0, -20, 0);

        StartCoroutine(ExecuteAfterTime(3));
        
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        Debug.Log(time);
        yield return new WaitForSeconds(time);
        Debug.Log("Success!");
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
