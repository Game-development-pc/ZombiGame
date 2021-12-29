using UnityEngine;

/**
 * This component animates a door depending on whether a player or an enemy is nearby.
 */
public class DoorBool : MonoBehaviour
{
    private Animator _animator;
    public get get;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && get.GetKey()==true )
        {
            _animator.SetBool("character_nearby", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _animator.SetBool("character_nearby", false);
    }
}