using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject coin;

    public void SpawnCoin()
    {
        float spawnPointX = Random.Range(-6, 8);
        float spawnPointY = Random.Range(-4, 4);

        Vector2 spawnPosition = new Vector2(spawnPointX, spawnPointY);
        
        Instantiate(coin, spawnPosition, Quaternion.identity);
    }
}