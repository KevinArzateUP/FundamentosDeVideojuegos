using System;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public MainPlayerPlatformer mainPlayer;
    
    public SpriteRenderer spriteRenderer;
    public Color transparentColor;
    public Color solidColor;

    public Sprite newSprite;

    private void OnEnable()
    {
        mainPlayer.OnPlayerJump += PlayerHasJump;
    }

    private void PlayerHasJump()
    {
        Debug.Log("El player salto");
    }

    private void OnDisable()
    {
        mainPlayer.OnPlayerJump -= PlayerHasJump;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        spriteRenderer.color = transparentColor;
        spriteRenderer.sprite = newSprite;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Player encima de este objeto");   
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        spriteRenderer.color = solidColor;
    }
}
