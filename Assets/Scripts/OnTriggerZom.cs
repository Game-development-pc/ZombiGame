using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerZom : MonoBehaviour
{
    AudioSource audioData;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
            // Start is called before the first frame update
            void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        audioData.Pause();
    }
}
