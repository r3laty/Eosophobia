using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 1f;
    [SerializeField] private float maxLookAngle = 50f;

    private PlayerController _playerController;

    private Transform _playerBody;

    private float _xRotation;
    private void Awake()
    {
        _playerController = GetComponentInParent<PlayerController>();
        _playerBody = _playerController.transform;
    }
    private void Update()
    {
        CameraFpsController();
    }
    private void CameraFpsController()
    {
        Vector2 cameraInput = InputManager.Instance.CameraLookVector();

        float mouseX = cameraInput.x * mouseSensitivity * Time.fixedDeltaTime;
        float mouseY = cameraInput.y * mouseSensitivity * Time.fixedDeltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -maxLookAngle, maxLookAngle);

        transform.localRotation = Quaternion.Euler(_xRotation, 180, 0);
        _playerBody.Rotate(Vector3.up * mouseX);
    }
}
