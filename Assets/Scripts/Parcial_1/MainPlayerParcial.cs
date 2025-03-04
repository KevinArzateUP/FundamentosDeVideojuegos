using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayerParcial : MonoBehaviour
{
    public float speed = 3f;
    public int vidas = 3;
    public int score = 0;
    public ObjectPooling bulletPooling;
    public Transform pointToShoot;
    public Animator animator;
    public TextMeshProUGUI textScore;

    public Image[] imgLives;

    public Canvas canvasGameOver;
    // Update is called once per frame
    void Update()
    {
        if (vidas > 0)
        {
            Vector3 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            transform.position += moveVector * speed * Time.deltaTime;

            if (Input.GetButtonDown("Fire1"))
            {
                bulletPooling.GetObject(pointToShoot.position);
            }
        }
        else
        {
            canvasGameOver.enabled = true;
        }
        

    }

    public void RecibirDanio()
    {
        vidas--;
        imgLives[vidas].enabled = false;
        animator.SetTrigger("Damage");
    }

    public void AumentarScore()
    {
        score += 100;
        textScore.text = score.ToString();
    }
}
