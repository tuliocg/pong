using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float _speedX = -5f;
    private float _speedY = 5f;
    private Rigidbody2D rb;
    private Collider2D cl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.gameObject.name == "Player")
        {
            Debug.Log("Collision player detected");
            rb.linearVelocityX = -1 * _speedX;
            _speedX = -1 * _speedX;
        }
        else if(collision.transform.gameObject.name == "Opponent")
        {
            Debug.Log("Collision opponent detected");
            rb.linearVelocityX = -1 * _speedX;
            _speedX = -1 * _speedX;
        }
        else if(collision.transform.gameObject.name == "PlayerGoal")
        {
            Debug.Log("Goal from the Opponent");
            transform.position = new Vector2(0, 0);
        }
        else if(collision.transform.gameObject.name == "OpponentGoal")
        {
            Debug.Log("Goal from the Player");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Collision wall detected");
            rb.linearVelocityY = -1 * _speedY;
            _speedY = -1 * _speedY;
        }

    }
    // Update is called once per frame
    void Update()
    {
       rb.linearVelocityY = _speedY;
       rb.linearVelocityX = _speedX;
    }

}
