using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
public class HeavyDamage : DamageDealer
{

    [SerializeField] private GameObject bullet;
    [Space]
    [SerializeField] private float bulletsPerShot = 6;
    [Space]
    [SerializeField] private Camera fpsCamera;
    [Space]
    [SerializeField] private float fireRange;
    [Space]
    [SerializeField] private float rechargingTime = 1.2f;

    private float _damage;
    private RaycastHit _raycastHit;
    private HealthController _enemyHealth;
    private bool _isReadyForShot = true;

    private void Start()
    {
        _damage = Damage;
    }

    public void Shot()
    {
        if (_isReadyForShot)
        {
            for (int bulletCounter = 0; bulletCounter < bulletsPerShot; bulletCounter++)
            {
                if (Physics.Raycast(fpsCamera.transform.position, GetShootingDirection(), out _raycastHit, fireRange))
                {
                    Instantiate(bullet, _raycastHit.point, Quaternion.identity);

                    if (_raycastHit.collider.CompareTag(enemyTag.ToString()))
                    {
                        _raycastHit.collider.TryGetComponent<HealthController>(out _enemyHealth);
                    }
                }
            }
            if (_enemyHealth != null)
            {
                _enemyHealth.ReceiveDamage(_damage);
            }
            else
            {
                Debug.Log("CANT FIND HEALTH CONTROLLER");
            }

            _isReadyForShot = false;
            StartCoroutine(RechargeGun());
        }
    }
    private Vector3 GetShootingDirection()
    {
        Vector3 direction = fpsCamera.transform.forward;
        Vector3 spread = Vector3.zero;
        spread += fpsCamera.transform.up * Random.Range(-1f, 1f);
        spread += fpsCamera.transform.right * Random.Range(-1f, 1f);

        direction += spread.normalized * Random.Range(0f, 0.2f);
        return direction;
    }
    private IEnumerator RechargeGun()
    {
        yield return new WaitForEndOfFrame();
        _enemyHealth = null;
        yield return new WaitForSeconds(rechargingTime);
        _isReadyForShot = true;
    }
}
