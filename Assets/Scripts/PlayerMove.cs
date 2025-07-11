    using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public Transform tr;
    Vector2 playerTr;
    Vector2 playerInput;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        playerTr = tr.position;
        Vector2 destination = playerTr + playerInput * Time.deltaTime * moveSpeed;
        destination.x = Mathf.Clamp(destination.x, -50, 50);
        destination.y = Mathf.Clamp(destination.y, -25, 25);
        transform.position = destination;
    }

    private void OnMove(InputValue value)
    {
        playerInput = value.Get<Vector2>(); 
    }
}
