using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    [SerializeField] private List<GunController> weapons;

    private InputManager _inputManager;
    private int _currentGunId;

    private int _melleeWeaponId = 0;
    private int _middleWeaponId = 1;
    private int _pistolId = 2;
    private void Start()
    {
        _inputManager = InputManager.Instance;
    }

    private void Update()
    {
        switch (_inputManager.SwitchWeaponsInput())
        {
            case Keys.KeyOne:
                Switch(_melleeWeaponId);
                break;

            case Keys.KeyTwo:
                Switch(_middleWeaponId);
                break;

            case Keys.KeyThree:
                Switch(_pistolId);
                break;

            case Keys.Null:
                Debug.Log($"No weapon by id {_currentGunId}");
                break;
        }
    }
    private void Switch(int id)
    {
        weapons[_currentGunId].gameObject.SetActive(false);

        weapons[id].gameObject.SetActive(true);
        _currentGunId = id;
    }
}
