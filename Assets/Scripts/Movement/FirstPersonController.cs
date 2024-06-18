using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]
public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private bool lockCursor = true;
    [SerializeField] private bool dynamicFov = true;
    [Header("Camera")]
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private float fovWhenSprint;
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private float maxLookAngle = 50f;
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float crouchHeight = 0.5f;
    [Header("Jump")]
    [SerializeField] private float jumpForce = 5f;
    [SerializeField, Min(0.1f)] private float checkGroundDistance = 1f;

    private NewInputSystem _gameInput;
    private Rigidbody _rb;

    private Vector3 _inputVector;
    private Vector3 _cameraInputVector;
    private Vector3 _originalScale;

    private bool _isGrounded;

    private float _normalSpeed;
    private float _initialFov;

    private float _pitch;
    private float _rotationAngle;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _gameInput = new NewInputSystem();

        _gameInput.Enable();

        _gameInput.Gameplay.Jump.performed += Jump;

        _gameInput.Gameplay.Crouch.performed += Crouch;
        _gameInput.Gameplay.Crouch.canceled += Crouch_canceled;

        _gameInput.Gameplay.Sprint.performed += Sprint;
        _gameInput.Gameplay.Sprint.canceled += Sprint_canceled;

    }
    private void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        _originalScale = transform.localScale;
        _normalSpeed = moveSpeed;
        _initialFov = fpsCamera.fieldOfView;
    }
    private void Update()
    {
        _inputVector = _gameInput.Gameplay.Movement.ReadValue<Vector3>();
        _cameraInputVector = _gameInput.Gameplay.Camera.ReadValue<Vector3>();
    }
    private void FixedUpdate()
    {
        Vector3 inputDirection = new Vector3(-_inputVector.x * moveSpeed * Time.fixedDeltaTime, _rb.velocity.y, -_inputVector.z * moveSpeed * Time.fixedDeltaTime);

        _rb.velocity = inputDirection;
    }
    private void LateUpdate()
    {
        _rotationAngle = transform.localEulerAngles.y + _cameraInputVector.x * mouseSensitivity;

        _pitch -= mouseSensitivity * _cameraInputVector.y;
        _pitch = Mathf.Clamp(_pitch, -maxLookAngle, maxLookAngle);

        transform.localEulerAngles = new Vector3(0, _rotationAngle, 0);
        fpsCamera.transform.localEulerAngles = new Vector3(_pitch, 0, 0);
    }
    private void Jump(InputAction.CallbackContext callbackContext)
    {
        CheckGround();
        if (_isGrounded)
        {
            _rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
        }
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
    private void Crouch(InputAction.CallbackContext callbackContext)
    {
        transform.localScale = new Vector3(_originalScale.x, crouchHeight, _originalScale.z);
        moveSpeed /= 2;
    }
    private void Crouch_canceled(InputAction.CallbackContext callbackContext)
    {
        transform.localScale = _originalScale;
        moveSpeed = _normalSpeed;
    }
    private void Sprint(InputAction.CallbackContext contecallbackContextxt)
    {
        moveSpeed *= 2;
        if (dynamicFov)
        {
            fpsCamera.fieldOfView = fovWhenSprint;
        }
    }
    private void Sprint_canceled(InputAction.CallbackContext callbackContext)
    {
        moveSpeed = _normalSpeed;
        if (dynamicFov)
        {
            fpsCamera.fieldOfView = _initialFov;
        }
    }


    private void OnDisable()
    {
        _gameInput.Gameplay.Jump.performed -= Jump;

        _gameInput.Gameplay.Crouch.performed -= Crouch;
        _gameInput.Gameplay.Crouch.canceled -= Crouch_canceled;

        _gameInput.Gameplay.Sprint.performed -= Sprint;
        _gameInput.Gameplay.Sprint.canceled -= Sprint_canceled;

        _gameInput.Disable();
    }
}