using UnityEngine;
using UnityEngine.AI;

public class EnemieController : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    public Transform targetObj;

    private void Start()
    {
        
    }
    private void Update()
    {
       transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 2 * Time.deltaTime);

        enemy.SetDestination(player.position);
    }
   
}
