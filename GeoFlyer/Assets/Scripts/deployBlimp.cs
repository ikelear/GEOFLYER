using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBlimp : MonoBehaviour
{
    public GameObject blimpPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(blimpWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(blimpPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x) , screenBounds.y * 2);
    }

    IEnumerator blimpWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

   
}
