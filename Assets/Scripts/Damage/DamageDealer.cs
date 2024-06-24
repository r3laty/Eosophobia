using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float Damage { get; private set; }

    [SerializeField] private float damage;
    [SerializeField] private string enemyTag;

    private bool _enemy;
    private HealthController _healthController;
    private void Start()
    {
        Damage = damage;
    }
    public void DealDamage()
    {
        if (_enemy)
        {
            _healthController?.ReceiveDamage(Damage);
            _enemy = false;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag(enemyTag))
        {
            _enemy = true;
            collision.gameObject.TryGetComponent<HealthController>(out _healthController);
        }
    }
}
