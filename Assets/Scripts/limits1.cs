using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limits1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 2.7){
             transform.position = new Vector3(2.7f, transform.position.y,transform.position.z);
         }
        if(transform.position.x < -3f){
             transform.position = new Vector3(-3f, transform.position.y,transform.position.z);
         }
}
}
