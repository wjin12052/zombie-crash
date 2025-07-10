using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Transform playerTr;
    Rigidbody2D rb;
    public float movespeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, playerTr.position);
        Debug.Log(distance);
        if (distance > 1.4f)
        {

            Vector2 targetposition = Vector2.MoveTowards(transform.position, playerTr.position, movespeed * Time.deltaTime);
            rb.MovePosition(targetposition);
        }
        
    }
}
