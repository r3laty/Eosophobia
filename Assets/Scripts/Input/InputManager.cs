using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private InputActions _gameInput;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _gameInput = new InputActions();

        _gameInput.Enable();
    }
    public Vector2 CameraLookVector()
    {
        return _gameInput.Gameplay.MouseLook.ReadValue<Vector2>();
    }
    public Vector2 MovementVector()
    {
        return _gameInput.Gameplay.Movement.ReadValue<Vector2>();
    }
    public bool JumpInput()
    {
        if (_gameInput.Gameplay.Jump.triggered)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public InputKeys SwitchWeaponsInput()
    {
        if (_gameInput.InGameUi.WeaponChangeKeyOne.triggered)
        {
            return InputKeys.KeyOne;
        }

        else if (_gameInput.InGameUi.WeaponChangeKeyTwo.triggered)
        {
            return InputKeys.KeyTwo;
        }

        else if (_gameInput.InGameUi.WeaponChangeKeyThree.triggered)
        {
            return InputKeys.KeyThree;
        }
        else
        {
            return InputKeys.Null;
        }
    }
    public bool ShootInput()
    {
        if (_gameInput.Gameplay.Attack.triggered)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnDisable()
    {
        _gameInput.Disable();
    }
}
