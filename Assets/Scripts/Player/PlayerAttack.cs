using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private MelleeDamage melleeGun;
    [SerializeField] private HeavyDamage heavyGun;

    private InputManager _inputManager;
    private int _gunId;
    private void Start()
    {
        _inputManager = InputManager.Instance;
    }
    private void Update()
    {
        if (_inputManager.ShootInput())
        {
            MakeShot();
        }
    }
    public void ChooseType(int id)
    {
        _gunId = id;
    }
    private void MakeShot()
    {
        switch (_gunId)
        {
            case 0:
                melleeGun.DealDamage();
                break;

            case 1:
                heavyGun.Shot();
                break;
        }
    }
}
