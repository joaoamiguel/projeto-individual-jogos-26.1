using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject food;

    public void SpawnFood()
    {
        float spawnPointX = Random.Range(-6, 8);
        float spawnPointY = Random.Range(-4, 4);

        Vector2 spawnPosition = new Vector2(spawnPointX, spawnPointY);
        
        Instantiate(food, spawnPosition, Quaternion.identity);
    }
}