using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Get the NavMeshAgent component and set its destination to the target's position.
/// </summary>
public class Mover : MonoBehaviour
{
    /* A private variable that is visible in the inspector. */
    [SerializeField] private Transform target;
    
    /// <summary>
    /// Get the NavMeshAgent component and set its destination to the target's position.
    /// </summary>
    private void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
