using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    public float timeToWait = 5f;
    public MovementPlayer3d currentPlayer;
    public Coroutine currentRutine;
    void Start()
    {
        currentRutine = StartCoroutine(RoutineWait());
    }

    [ContextMenu("Try to stop rutine")]
    public void StopRutinesOfThisClass()
    {
        StopCoroutine(currentRutine);
    }

    public IEnumerator RoutineWait()
    {
        currentPlayer.speed = 0;
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("Finished rutine");
        currentPlayer.speed = 3f;
    }
}
