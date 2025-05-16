using System;
using UnityEngine;

public class UserinterfaceHandler : MonoBehaviour
{
    public Canvas canvasGameOver;
    public MovementPlayer3d mainPlayer;

    private void OnEnable()
    {
        mainPlayer.OnPlayerDeath += PlayerDamaged;
    }

    private void OnDisable()
    {
        mainPlayer.OnPlayerDeath -= PlayerDamaged;
    }
    
    private void PlayerDamaged()
    {
        canvasGameOver.enabled = true;
    }
}
