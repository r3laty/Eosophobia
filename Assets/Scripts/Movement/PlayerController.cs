using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public InputActions GameInput;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [Space]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private CharacterController _controller;
    private Vector2 _inputVector;
    private Vector3 _velocity;
    private float _gravity = -9.81f;
    private bool _isGrounded;
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        GameInput = new InputActions();
        GameInput.Enable();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Gravity();
        PlayerMovement();
        Jump();
    }
    private void Gravity()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, 10, groundLayer);

        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -3f;
        }

        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
    private void PlayerMovement()
    {
        _inputVector = GameInput.Gameplay.Movement.ReadValue<Vector2>();

        Vector3 movement = (_inputVector.y * transform.forward) + (_inputVector.x * transform.right);
        _controller.Move(movement * moveSpeed * Time.deltaTime);
    }
    private void Jump()
    {
        if(GameInput.Gameplay.Jump.triggered)
        {
            _velocity.y = Mathf.Sqrt(jumpForce * -2f * _gravity);
        }
    }

    private void OnDisable()
    {
        GameInput.Disable();
    }
}
