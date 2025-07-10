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
        Vector2 targetposition = Vector2.MoveTowards(transform.position, playerTr.position, movespeed *  Time.deltaTime);
        rb.MovePosition(targetposition);
        
    }
}
