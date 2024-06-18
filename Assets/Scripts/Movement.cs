using System;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [Header("Camera")]
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private float fovWhenSprint;
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float crouchHeight = 0.5f;
    [Header("Jump")]
    [SerializeField] private float jumpForce = 5f;
    [SerializeField, Min(0.1f)] private float checkGroundDistance = 1f;

    private NewInputSystem _gameInput;
    private Rigidbody _rb;

    private Vector3 _inputVector;
    private Vector3 _originalScale;

    private bool _isCrouch;
    private bool _isSprint;
    private bool _isJump;
    private bool _isGrounded;

    private float _normalSpeed;
    private float _initialFov;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _gameInput = new NewInputSystem();

        _gameInput.Enable();

        _gameInput.Gameplay.Jump.performed += Jump;
        _gameInput.Gameplay.Jump.canceled += Jump_cancaled;

        _gameInput.Gameplay.Crouch.performed += Crouch;
        _gameInput.Gameplay.Crouch.canceled += Crouch_canceled;

        _gameInput.Gameplay.Sprint.performed += Sprint;
        _gameInput.Gameplay.Sprint.canceled += Sprint_canceled;

    }
    private void Start()
    {
        _originalScale = transform.localScale;
        _normalSpeed = moveSpeed;
        _initialFov = fpsCamera.fieldOfView;
    }


    private void Update()
    {
        _inputVector = _gameInput.Gameplay.Movement.ReadValue<Vector3>();
    }
    private void FixedUpdate()
    {
        Vector3 inputDirection = new Vector3(-_inputVector.x, _rb.velocity.y, -_inputVector.z);

        _rb.velocity = new Vector3(-_inputVector.x * moveSpeed * Time.fixedDeltaTime,
            _rb.velocity.y, -_inputVector.z * moveSpeed * Time.fixedDeltaTime);
        if (_isCrouch)
        {
            transform.localScale = new Vector3(_originalScale.x, crouchHeight, _originalScale.z);
        }
        else
        {
            transform.localScale = _originalScale;
        }

        if (_isSprint)
        {
            //Logic
        }
        else
        {
            fpsCamera.fieldOfView = _initialFov;
        }

        if (_isJump && _isGrounded)
        {
            //_rb.AddForce(0f, jumpForce * Time.fixedDeltaTime, 0f, ForceMode.Impulse);
        }
        else
        {
            //Logic
        }
    }
    private void Jump(InputAction.CallbackContext callbackContext)
    {
        if (_isGrounded)
        {
            _rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
        }
        CheckGround();
    }
    private void Jump_cancaled(InputAction.CallbackContext context)
    {
        _isJump = false;
    }
    private void CheckGround()
    {
        Vector3 origin = new Vector3(transform.position.x, transform.position.y - (transform.localScale.y * .5f), transform.position.z);
        Vector3 direction = transform.TransformDirection(Vector3.down);
        float distance = checkGroundDistance;

        if (Physics.Raycast(origin, direction, out RaycastHit hit, distance))
        {
            Debug.DrawRay(origin, direction * distance, Color.red);
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }
    }
    private void Crouch(InputAction.CallbackContext obj)
    {
        _isCrouch = true;
        moveSpeed /= 2;
    }
    private void Crouch_canceled(InputAction.CallbackContext context)
    {
        _isCrouch = false;
        moveSpeed = _normalSpeed;
    }
    private void Sprint(InputAction.CallbackContext context)
    {
        _isSprint = true;
        moveSpeed *= 2;
        fpsCamera.fieldOfView = fovWhenSprint;
    }
    private void Sprint_canceled(InputAction.CallbackContext context)
    {
        _isSprint = false;
        moveSpeed = _normalSpeed;
    }


    private void OnDisable()
    {
        _gameInput.Gameplay.Jump.performed -= Jump;
        _gameInput.Gameplay.Jump.performed -= Jump_cancaled;

        _gameInput.Gameplay.Crouch.performed -= Crouch;
        _gameInput.Gameplay.Crouch.canceled -= Crouch_canceled;

        _gameInput.Disable();
    }
}