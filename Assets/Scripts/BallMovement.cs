using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Collider2D cl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       //rb.linearVelocity = new Vector2(5f, rb.linearVelocity.y);
       rb.AddForce(transform.up * 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected");
        rb.AddForce(new Vector2(-1, 0) * 10f);

    }
}
