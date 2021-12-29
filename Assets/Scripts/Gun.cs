using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damge = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public Animator anim;
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.T)) fpsCam.transform.position += new Vector3(-1.6f, 0.4f, 0.2f);
        //if (Input.GetKeyDown(KeyCode.E)) fpsCam.transform.position += new Vector3(1.6f, -0.4f, -0.2f);
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Shoot", true);
            Shoot();
            audioData.Play(0);
        }
        if(Input.GetMouseButton(1))
        {
            anim.SetBool("Shoot", false);
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamge(damge);
            }
        }
    }
}
