using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttakZombie : MonoBehaviour
{
    public float damge = 10f;
    public Animator anim;
    private bool attak;
    private Player player;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("in");
            player = other.transform.GetComponent<Player>();
            attak = true;
            StartCoroutine(delyattak());
            anim.SetBool("Attak", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        attak = false;
        anim.SetBool("Attak", false);
    }
    private void Attak()
    {
        if (anim.GetBool("Death")) return;
        player.TakeDamage(damge);
    }
    private IEnumerator delyattak()
    {
        while (attak)
        {
            Attak();
            yield return new WaitForSeconds(2F);
            
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}