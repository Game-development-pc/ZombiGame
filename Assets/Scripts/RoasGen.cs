using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoasGen : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other){
        transform.position += new Vector3(0,0,transform.GetChild(0).GetComponent<Renderer>().bounds.size.z * 5);
    }
}
