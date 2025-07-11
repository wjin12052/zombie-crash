using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("µé¾î¿È");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
        }
    }
}
