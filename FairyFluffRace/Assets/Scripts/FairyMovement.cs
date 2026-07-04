using UnityEngine;
using UnityEngine.InputSystem;

public class FairyMovement : MonoBehaviour
{
    private InputSystem_Actions controls;

    [SerializeField] private float groundedSpeed;
    [SerializeField] private float airSpeed;
    private Vector2 moved;

    void Awake() {
        controls = new InputSystem_Actions();

        controls.Player.Move.performed += ctx => moved = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moved = Vector2.zero;
    }
    
    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(moved * Time.deltaTime);
    }

    void Move(Vector2 direction)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb == null) return;
        float speed = groundedSpeed; //will always be grounded for now.
        //float speed = rb.IsTouchingLayers(LayerMask.GetMask("Ground")) ? groundedSpeed : airSpeed;
        rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
    }
}
