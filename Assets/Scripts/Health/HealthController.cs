using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float Health { get; private set; }

    [SerializeField] private float maxHealth;
    private void Start()
    {
        Health = maxHealth;
    }
    public void ReceiveDamage(float damage)
    {
        Health -= damage;
        Debug.Log($"Character {gameObject.name} \nHp {Health}");
        CheckIsDied();
    }
    private void CheckIsDied()
    {
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
