using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour {
    private Vector2 moveInput;
    private float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // Automatically called by Player Input component (Behavior: Send Messages)
    public void Move(InputAction.CallbackContext context) {
        Debug.Log(context.ReadValue<Vector2>());
        moveInput = context.ReadValue<Vector2>();
    }

    void Update() {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}