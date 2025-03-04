using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 3f;

    private void OnBecameInvisible()
    {
        Debug.Log("Sali de la vista de TODAS las camaras");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ya alcanzo el limite del escenario");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
        if (transform.position.x < -50)
        {
            gameObject.SetActive(false);
        }
    }
}
