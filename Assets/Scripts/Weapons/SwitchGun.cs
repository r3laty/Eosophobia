using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    [SerializeField] private List<GunController> weapons;
    [Space]
    [SerializeField] private PlayerAttack playerAttack;

    private InputManager _inputManager;
    private int _currentGunId;

    private int _melleeWeaponId = 0;
    private int _heavyWeaponId = 1;
    private int _pistolId = 2;
    private void Start()
    {
        _inputManager = InputManager.Instance;
    }

    private void Update()
    {
        switch (_inputManager.SwitchWeaponsInput())
        {
            case InputKeys.KeyOne:
                Switch(_melleeWeaponId);
                break;

            case InputKeys.KeyTwo:
                Switch(_heavyWeaponId);
                break;

            case InputKeys.KeyThree:
                Switch(_pistolId);
                break;

            case InputKeys.Null:
                Debug.Log("No weapon for this button");
                break;
        }
    }
    private void Switch(int id)
    {
        playerAttack.ChooseType(id);

        weapons[_currentGunId].gameObject.SetActive(false);

        weapons[id].gameObject.SetActive(true);
        _currentGunId = id;
    }
}
