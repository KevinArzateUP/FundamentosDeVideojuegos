using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainPlayerPlatformer : MonoBehaviour
{
    public delegate void PlayerHasJump();
    public PlayerHasJump OnPlayerJump;
    
    public delegate void PlayerHasShoot();
    public PlayerHasShoot OnPlayerShoot;
        
    public Animator animatorPlayer;
    public float speed = 3f;
    public float jumpForce = 5f;
    public Rigidbody2D rigidbody2D;

    public bool isOnGround;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (transform.position.y > other.contacts[0].point.y)
            isOnGround = true;
    }

    private void Awake()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animatorPlayer.SetFloat("Speed",  Input.GetAxis("Horizontal"));
        //transform.position += Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal");
        //transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime * speed);

        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            isOnGround = false;
            if (OnPlayerJump!=null)
                OnPlayerJump.Invoke();
            animatorPlayer.SetTrigger("Jump");
            //rigidbody2D.AddForce(Vector2.up*force, ForceMode2D.Impulse);
            rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x, jumpForce);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (OnPlayerShoot!=null)
                OnPlayerShoot.Invoke();
        }
    }
    
    private void FixedUpdate()
    {
        rigidbody2D.linearVelocity = new Vector2( Input.GetAxis("Horizontal") * speed, rigidbody2D.linearVelocity.y );
        //rigidbody2D.MovePosition(transform.position + Vector3.right * speed * Input.GetAxis("Horizontal"));
    }
}
