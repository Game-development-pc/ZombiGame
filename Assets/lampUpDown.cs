using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lampUpDown : MonoBehaviour
{
    
    //public Light lightComp;


    private IEnumerator Off()
    {
        
        yield return new WaitForSeconds(0.5F);
        this.GetComponent<Light>().enabled = false;
      

    }
    private IEnumerator On()
    {
        yield return new WaitForSeconds(3F);
        this.GetComponent<Light>().enabled = true;

    }

    void Start()
    {
        
    }


        void Update()
    {
        StartCoroutine(Off());
        StartCoroutine(On());
    }
}
