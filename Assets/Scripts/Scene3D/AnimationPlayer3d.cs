using UnityEngine;

public class AnimationPlayer3d : MonoBehaviour
{
    public float speed;
    public Animator animator;
    void Update()
    {
        speed = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", speed);
    }
}
