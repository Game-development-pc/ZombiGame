using UnityEngine;

public class Target : MonoBehaviour
{
    public Animator anim;
    public float health = 50f;
    public bool destroy;
    //public Animator anim;

    public void TakeDamge(float amount)
    {
        health -= amount;
        if( health <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        if (destroy) Destroy(gameObject);
        anim.SetBool("Death", true);
    }
}
