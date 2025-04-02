using System;
using System.Collections;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    public Animator animatorDoor;

    private void OnTriggerEnter(Collider other)
    {
        animatorDoor.Play("Open");
        Debug.Log("**** Antes de lanzar la rutina");
        StartCoroutine(RoutineCloseDoor());
        Debug.Log("**** Despues de lanzar la rutina"); 
    }

    private IEnumerator RoutineCloseDoor()
    {
        Debug.Log("Comence la corutina");
        yield return new WaitForSeconds(3f);
        Debug.Log("Termine la corutina");
    }
}
