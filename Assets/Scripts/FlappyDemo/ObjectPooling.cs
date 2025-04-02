using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectPooling : MonoBehaviour
{
    public int objectCount = 5;
    public GameObject prefabObject;
    public List<GameObject> createdObjects;

    private void Awake()
    {
        FillObjects();
    }

    public void FillObjects()
    {
        for (int i = 0; i < objectCount; i++)
        {
            GameObject instancedObject = Instantiate(prefabObject);
            instancedObject.SetActive(false);
            createdObjects.Add(instancedObject);
        }
    }

    public void GetObject(Transform point)
    {
        for (int i = 0; i < createdObjects.Count; i++)
        {
            if (!createdObjects[i].activeInHierarchy)
            {
                
                createdObjects[i].transform.position = point.position;
                createdObjects[i].transform.rotation = point.rotation;
                createdObjects[i].SetActive(true);
                return;
            }
        }
    }
    
    public void GetObject(Vector3 position)
    {
        for (int i = 0; i < createdObjects.Count; i++)
        {
            if (!createdObjects[i].activeInHierarchy)
            {
                createdObjects[i].transform.position = position;
                createdObjects[i].SetActive(true);
                return;
            }
        }
    }
    
}
