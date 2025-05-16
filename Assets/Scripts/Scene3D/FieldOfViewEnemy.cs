using System;
using UnityEngine;

public class FieldOfViewEnemy : MonoBehaviour
{
    public NavigationSystem thisEnemy;
    private void OnTriggerEnter(Collider other)
    {
        thisEnemy.currentState = NavigationSystem.EnumStates.chase;
    }

    private void OnTriggerExit(Collider other)
    {
        thisEnemy.currentState = NavigationSystem.EnumStates.wait;
    }
}
