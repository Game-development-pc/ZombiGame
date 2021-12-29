using System;
using UnityEngine;
using UnityEngine.AI;


/**
 * This component represents an enemy NPC that chases the player.
 */
[RequireComponent(typeof(NavMeshAgent))]
public class Chaser : MonoBehaviour
{
    internal bool flag;
    private bool trigger;
  
    private Player player;

    [Header("These fields are for display only")]
    [SerializeField] private Vector3 playerPosition;

    public Animator animator;
    private NavMeshAgent navMeshAgent;
    AudioSource audioData;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if((animator.GetBool("Death"))) 
            {
                trigger = false;
                animator.SetBool("Show", false);
            }
            else
            {
                audioData.Play(0);
                trigger = true;
                player = other.transform.GetComponent<Player>();
                animator.SetBool("Show", true);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = false;
            Debug.Log("Exit");
            animator.SetBool("Show", false);
            audioData.Pause();
        }
    }

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioData = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (trigger)
        {
            if (!(animator.GetBool("Death")))
            {
                playerPosition = player.transform.position;
                float distanceToPlayer = Vector3.Distance(playerPosition, transform.position);
                FacePlayer();
                navMeshAgent.SetDestination(playerPosition);
            }
            else navMeshAgent.SetDestination(this.transform.position);
        }
            if (!trigger)
            {
                navMeshAgent.SetDestination(this.transform.position);
            }
    }
    private void FacePlayer()
    {
        Vector3 direction = (playerPosition - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

    

    private void FaceDirection()
    {
        Vector3 direction = (navMeshAgent.destination - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);
    }

}