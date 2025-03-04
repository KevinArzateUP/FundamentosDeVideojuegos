using System;
using UnityEngine;

public class EnemyParcial : MonoBehaviour
{
    public float moveSpeed = 4f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<MainPlayerParcial>())
        {
            other.gameObject.GetComponent<MainPlayerParcial>().RecibirDanio();
        }
        
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
