using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private float timeSinceStart = 0;
    private float timeToSpawn = 3f;
    public ObjectPooling[] generatorObstacle;

    // Update is called once per frame
    void Update()
    {
        timeSinceStart += Time.deltaTime;
        if (timeSinceStart > timeToSpawn)
        {
            timeSinceStart = 0;
            generatorObstacle[Random.Range(0,generatorObstacle.Length)].GetObject();    
        }
        

    }
}
