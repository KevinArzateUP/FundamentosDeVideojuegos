using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 2;
    public float moveSpeed = 3f;
    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {
        
        IDamagable damagable = other.gameObject.GetComponent<IDamagable>();
        if (damagable!=null)
            damagable.OnReceiveDamage(damage);
        
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
    
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
