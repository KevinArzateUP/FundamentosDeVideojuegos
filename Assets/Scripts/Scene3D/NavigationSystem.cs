using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavigationSystem : MonoBehaviour
{
    // Patrol
    public NavMeshAgent agent;
    public Transform[] patrolPoints;
    private int currentIndex = 0;
    // Wait
    private float currentTime;
    public float maxTimeToWait = 2f;
    // Chase
    public Transform player;
    
    public EnumStates currentState;
    public enum EnumStates
    {
        patrol,
        wait,
        chase,
        attack
    }
    
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        GoToNextPoint();
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnumStates.patrol:
                if (agent.remainingDistance < 1)
                {
                    currentTime = 0;
                    currentState = EnumStates.wait;
                } 
                break;
            
            case EnumStates.wait:
                currentTime += Time.deltaTime;
                if (currentTime > maxTimeToWait)
                {
                    GoToNextPoint();
                    currentState = EnumStates.patrol;
                }
                break;
            
            case EnumStates.chase:
                agent.SetDestination(player.position);
                if (agent.remainingDistance < 1)
                {
                    currentTime = 0;
                    currentState = EnumStates.attack;
                } 
                break;
        }
        
    }

    private void GoToNextPoint()
    {
        currentIndex++;
        if (currentIndex >= patrolPoints.Length)
            currentIndex = 0;
        agent.SetDestination(patrolPoints[currentIndex].position);
    }
    
}
