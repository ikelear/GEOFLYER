using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosiondetector;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        transform.position = new Vector3(0, -20, 0);
        explosiondetector.SetActive(false);

        StartCoroutine(ExecuteAfterTime(3));
        
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
