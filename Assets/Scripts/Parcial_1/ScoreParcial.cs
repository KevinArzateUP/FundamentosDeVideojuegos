using UnityEngine;

public class ScoreParcial : MonoBehaviour
{
    public float moveSpeed = 4f;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        MainPlayerParcial playerReference = other.gameObject.GetComponent<MainPlayerParcial>(); 
        if (playerReference != null)
        {
            playerReference.AumentarScore();
        }
        
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
