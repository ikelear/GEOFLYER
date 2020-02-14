using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployBlimp : MonoBehaviour
{
    public GameObject blimpPrefab;
    public GameObject pigPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(blimpWave());
    }

    private void spawnBlimp()
    {
        GameObject a = Instantiate(blimpPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x) , screenBounds.y * 2);
    }
    private void spawnPig()
    {
        GameObject b = Instantiate(pigPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }

    IEnumerator blimpWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            int num = Random.Range(0, 2);
            
            if (num == 1)
            {
                spawnBlimp();
            }
            if(num == 0)
            {
                spawnPig();
            }
        }
    }

   
}
