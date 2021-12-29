using System.Collections;
using UnityEngine;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover : MonoBehaviour
{
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float speed = 3.5f;
    [SerializeField] float gravity = 9.81f;
    private float run = 1f;

    AudioSource audioData;

    private CharacterController cc;
    public Animator anim;
    void Start()
    {
        cc = GetComponent<CharacterController>();
        audioData = GetComponent<AudioSource>();
    }

    Vector3 velocity;

    void Update()
    {

        //if (cc.isGrounded)
        //{
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        anim.SetFloat("Vertical", z);
        anim.SetFloat("Horizontal", x);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioData.Play();
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            audioData.Pause();
        }


        if (!(anim.GetBool("Shoot")) && Input.GetKey(KeyCode.LeftShift))
        {

            anim.SetBool("Shift", true);
            run = 1.8f;

        }
        else
        {
            run = 1;
            anim.SetBool("Shift", false);
        }

        velocity.x = x * speed * run;
        velocity.z = z * speed * run;
        //}
        // else
        //{
        //velocity.y -= gravity * Time.deltaTime;
        //}

        // Move in the direction you look:
        velocity = transform.TransformDirection(velocity);

        cc.Move(velocity * Time.deltaTime);
    }
}