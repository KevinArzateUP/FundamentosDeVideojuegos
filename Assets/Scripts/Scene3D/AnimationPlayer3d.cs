using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimationPlayer3d : MonoBehaviour
{
    public float speed;
    public Animator animator;
    void Update()
    {
        speed = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", speed);
    }

    void Function()
    {
        GameObject prefab;
        

        
        
    }
    
}