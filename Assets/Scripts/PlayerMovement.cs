using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float moveSpeed = 250f;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // Automatically called by Player Input component (Behavior: Send Messages)
    public void Move(InputAction.CallbackContext context) {
        Debug.Log(context.ReadValue<Vector2>());
        moveInput = context.ReadValue<Vector2>();
    }

    void FixedUpdate() {
        rb.linearVelocityY = moveInput.y * moveSpeed * Time.deltaTime;
    }
}