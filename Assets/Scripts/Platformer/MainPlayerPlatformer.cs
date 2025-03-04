using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayerPlatformer : MonoBehaviour
{
    public Animator animatorPlayer;
    public float speed = 3f;
    public float force = 5f;
    public Rigidbody2D rigidbody2D;
    public TextMeshProUGUI textInScene;
    public Image imagen;
    public Obstacle nombreVariable;

    // Update is called once per frame
    void Update()
    {
        // ESTO NUNCA!!!!!!!!!!!!!!!!!!!!!!!
        // DE VERDAD NUNCA HAGAS ESTO:
        GameObject.Find("BusquedaPorNombre");
        // POR FAVOR JAMAS!!!!!!!!!!!!
        
        int num = 3;
        textInScene.text = num.ToString();
        
        animatorPlayer.SetFloat("Speed",  Input.GetAxis("Horizontal"));
        transform.position += Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            animatorPlayer.SetTrigger("Jump");
            rigidbody2D.AddForce(Vector2.up*force, ForceMode2D.Impulse);
        }
    }
}
