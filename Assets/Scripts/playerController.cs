using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    float stepsize = 30f;
    float step = 4.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(0,0,stepsize * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position+= new Vector3((-step * Time.deltaTime),0,0);
        }
         if(Input.GetKey(KeyCode.RightArrow)){
            transform.position+= new Vector3((step * Time.deltaTime),0,0);
        }
    }
}
