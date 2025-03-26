using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public MainPlayerPlatformer mainPlayer;

    private void OnEnable()
    {
        mainPlayer.OnPlayerJump += PlayerHasJump;
    }

    private void PlayerHasJump()
    {
        Debug.Log("Voy a reproducir un sonido porque el player brinco");
    }

    private void OnDisable()
    {
        mainPlayer.OnPlayerJump -= PlayerHasJump;
    }
}
