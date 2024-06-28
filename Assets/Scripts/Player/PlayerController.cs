using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public InputActions GameInput;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private LayerMask groundLayer;
    [Space]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private CharacterController _characterController;
    
    private Vector2 _inputVector;
    private Vector3 _velocity;

    private float _gravity = -9.81f;
    
    private bool _isGrounded;
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();

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
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -3f;
        }

        _velocity.y += _gravity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }
    private void PlayerMovement()
    {
        _inputVector = InputManager.Instance.MovementVector();

        Vector3 movement = (-_inputVector.y * transform.forward) + (-_inputVector.x * transform.right);
        _characterController.Move(movement * moveSpeed * Time.deltaTime);
    }
    private void Jump()
    {
        if (InputManager.Instance.JumpInput() && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpForce * -2f * _gravity);
        }
    }
}