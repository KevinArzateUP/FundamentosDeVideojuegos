using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawnEnemies = 3f;
    public float timeToSpawnScores = 4f;

    public float currentTimeEnemies = 0;
    public float currentTimeScores = 0;
    
    public ObjectPooling poolEnemies;
    public ObjectPooling poolScores;

    // Update is called once per frame
    void Update()
    {
        currentTimeEnemies += Time.deltaTime;
        if (currentTimeEnemies > timeToSpawnEnemies)
        {
            currentTimeEnemies = 0;
            poolEnemies.GetObject();
        }
        
        currentTimeScores += Time.deltaTime;
        if (currentTimeScores > timeToSpawnScores)
        {
            currentTimeScores = 0;
            poolScores.GetObject();
        }
    }
}
