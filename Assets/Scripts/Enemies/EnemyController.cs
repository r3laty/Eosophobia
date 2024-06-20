using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform player;

    private NavMeshAgent _agent;
    private Animator _anim;

    private bool _walk = true;
    private bool _attack;
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {
        _agent.destination = player.position;

        if (_agent.velocity.x > 0 || _agent.velocity.z > 0 && _walk)
        {
            _anim.SetBool("Forward", true);
        }

        if (Vector3.Distance(transform.position, player.position) <= 1.5f)
        {
            Debug.Log("distance <= 1.5");
            _walk = false;
            _attack = true;
        }
        else
        {
            _attack = false;
            _walk = true;
        }

        if (_attack)
        {
            _anim.SetBool("Forward", false);
            _anim.SetTrigger("Attack");
        }

    }
}
