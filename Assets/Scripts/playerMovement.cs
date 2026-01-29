using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
     private Rigidbody2D rb;
    private Vector2 movementDirection;
    void Start()
    {
         rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection.x = Input.GetAxis("Horizontal");
        movementDirection.y = Input.GetAxis("Vertical");
        movementDirection.Normalize();
    }
    void FixedUpdate()
    {
        // Apply physics-based movement in FixedUpdate
        rb.velocity = movementDirection * moveSpeed;
    }
}
