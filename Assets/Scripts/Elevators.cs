using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevators : MonoBehaviour
{
    private float distance = 2.1f;
    private float Up = 0.1f;
    private float Down = -0.26f;
    [Tooltip("speed of the object")]
    [SerializeField] private float speed = 1f;
    private bool flagUp = true;
    private bool flagDown = false;


    //private void elevaUP()
    //{
        //if (flagUp)
        //{
            //Debug.Log("Up");
            //flagUp = false;
            //for (int i = 0; i < 250; i++)
            //{
                //transform.position += new Vector3(0, Up * Time.deltaTime, 0);
                //Debug.Log("Up");
           //}

            //flagDown = true;
        //}
        

    //}
   // private void elevaDown()
   // {
        //if (flagDown)
        //{
            //Debug.Log("Down");
            //flagDown = false;
            //transform.position = new Vector3(transform.position.x, Down * Time.deltaTime * speed, transform.position.z);
            //flagUp = true;
        //}
        

    //}
    void Start()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
     transform.position = new Vector3(transform.position.x, (Mathf.Sin(Time.time * speed) * distance) + 0.5f, transform.position.z);
    //if (Input.GetKeyDown(KeyCode.G))
    //{
    // elevaUP();

    //}
    //if (Input.GetKeyDown(KeyCode.H))
    //{
    //elevaDown()
    //}
    }
}
