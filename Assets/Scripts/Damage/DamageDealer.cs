using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float Damage { get; private set; }

    [SerializeField] private float damage;

    private bool _isPlayer;
    private HealthController _healthController;
    private void Start()
    {
        Damage = damage;
    }
    public void DealDamage()
    {
        if (_isPlayer)
        {
            _healthController.ReceiveDamage(Damage);
            _isPlayer = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _isPlayer = true;
            collision.gameObject.TryGetComponent<HealthController>(out HealthController healthController);
            if(healthController != null)
            {
                _healthController = healthController;
            }
        }
    }
}
