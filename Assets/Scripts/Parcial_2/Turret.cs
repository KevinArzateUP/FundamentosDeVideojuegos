using System;
using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour, IDamagable
{
    public float delayCooldown;
    private bool isShooting;
    public int health = 3;
    public ObjectPooling poolingBullets;
    public Transform shootPoint;
    public Transform mainPlayer;

    private void OnTriggerEnter(Collider other)
    {
        isShooting = true;
        mainPlayer = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        isShooting = false;
        mainPlayer = null;
    }

    IEnumerator Start()
    {
        while (health > 0)
        {
            yield return new WaitForSeconds(delayCooldown);
            if (isShooting)
                poolingBullets.GetObject(shootPoint);            
        }
    }
    
    void Update()
    {
        if (mainPlayer!=null)
            transform.LookAt(mainPlayer);
    }

    public void OnReceiveDamage(int damage)
    {
        
    }
}
