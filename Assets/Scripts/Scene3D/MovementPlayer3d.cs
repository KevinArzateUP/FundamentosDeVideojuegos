using UnityEngine;

public class MovementPlayer3d : MonoBehaviour
{
    public CharacterController controller;
    public Transform mainCamera;
    public float speed = 3f;

    public float gravity = -9.81f;

    public int jumpCount = 0;
    public float jumpHeight = 3f;
    public Vector3 velocity;
    
    void Update()
    {
        // Pregunta si esta parado en el piso...
        bool isOnGround = controller.isGrounded;
        // ... si es asi, ajusta la velocidad de caida a -2
        if (isOnGround && velocity.y < 0)
        {
            velocity.y = -2f;
            jumpCount = 0;
        }
        
        // Obtener los input vertical y horizontal
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Obtener vector hacia enfrente y hacia la derecha de la camara
        Vector3 forwardCamera = mainCamera.forward;
        Vector3 rightCamera = mainCamera.right;

        // Dejar la componente en Y de ambos vectores de la camara en 0
        // Para evitar que se mueve hacia arriba o hacia abajo
        forwardCamera.y = 0;
        rightCamera.y = 0;

        // Construir el vector de direcccion hacia donde va a avanzar mi personaje
        // respecto a los input
        Vector3 moveDirection = (forwardCamera * vertical) + (rightCamera * horizontal);
        
        // El personaje voltea a ver hacia la direccion donde esta caminando
        transform.LookAt(transform.position + moveDirection);
        
        // Mueve al personaje en la direccion que construimos previamente
        controller.Move(moveDirection * Time.deltaTime * speed);

        if (Input.GetButtonDown("Jump") && jumpCount<2)
        {
            velocity.y = Mathf.Sqrt(-2 * gravity * jumpHeight);
            jumpCount++;
        }
        
        // Agrega el vector de velocidad que maneja la gravedad al movimiento
        // del personaje
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
