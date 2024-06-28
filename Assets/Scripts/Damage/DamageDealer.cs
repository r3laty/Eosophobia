using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float Damage { get; private set; }

    [SerializeField] private float damage;
    [SerializeField] private TagManager enemyTag;

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
            _healthController = null;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag(enemyTag.ToString()))
        {
            _enemy = true;
            collision.gameObject.TryGetComponent<HealthController>(out _healthController);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(enemyTag.ToString()))
        {
            _enemy = true;
            other.TryGetComponent<HealthController>(out _healthController);
        }
    }
}
