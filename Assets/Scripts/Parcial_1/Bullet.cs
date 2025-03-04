using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.GetComponent<MainPlayerParcial>())
        {
            gameObject.SetActive(false);
        }
        
    }

    void Update()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
    
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
