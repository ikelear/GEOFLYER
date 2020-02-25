using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCoin : MonoBehaviour
{
    public GameObject coinPrefab;

    public float respawnTime = 2.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(coinWave());
    }

    private void spawnCoin()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }

    IEnumerator coinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
        }
    }

}




