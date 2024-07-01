using UnityEngine;
public class HeavyDamage : DamageDealer
{
    //[Space]
    //[SerializeField] private ParticleSystem fireEffect;
    [SerializeField] private GameObject bullet;
    [Space]
    [SerializeField] private float bulletsPerShot = 6;
    [Space]
    [SerializeField] private Camera fpsCamera;
    [Space]
    [SerializeField] private float fireRange;
    
    private float _damage;
    private RaycastHit _raycastHit;
    private void Start()
    {
        _damage = Damage;
    }

    public void Shot()
    {
        for (int bulletCounter = 0; bulletCounter < bulletsPerShot; bulletCounter++)
        {
            if (Physics.Raycast(fpsCamera.transform.position, GetShootingDirection(), out _raycastHit, fireRange))
            {
                Instantiate(bullet, _raycastHit.point, Quaternion.identity);
                Debug.DrawLine(fpsCamera.transform.position, _raycastHit.point, Color.green, 1f);
            }
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
}
