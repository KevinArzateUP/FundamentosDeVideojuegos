using System;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public float force;
    public Rigidbody2D rigidbody2D;
    private bool isAlive = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        isAlive = false;
        // singleton
        // object pooling
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
            return;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
        
    }
}
