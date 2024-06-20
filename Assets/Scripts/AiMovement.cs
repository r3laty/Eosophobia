using UnityEngine;
using UnityEngine.AI;

public class AiMovement : MonoBehaviour
{
    [SerializeField] private Transform destination;
    
    private NavMeshAgent _agent;
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        _agent.destination = destination.position;
    }
}
