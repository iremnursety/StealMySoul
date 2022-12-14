using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform player;

    // [SerializeField] private LayerMask playerMask;
    // [SerializeField]private LayerMask groundMask;
    //
    // [SerializeField] private Vector3 walkPoint;
    // [SerializeField] private bool walkPointSet;
    // [SerializeField] private float walkPointRange;
    // [SerializeField] private float sightRange, attackRange;
    // [SerializeField] private bool playerInSightRange, playerInAttackRange;
    
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        //navMeshAgent.SetDestination(player.position);
    }

    private void Update()
    {
        navMeshAgent.SetDestination(player.position);
        
    }

    // private void Patrolling()
    // {
    //     
    // }
    //
    // private void ChasePlayer()
    // {
    //     
    // }
}
