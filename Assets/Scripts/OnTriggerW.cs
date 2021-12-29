using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OnTriggerW : MonoBehaviour
{
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            for(int i = 3; i > 0; i++){
            
            }
            SceneManager.LoadScene(5);
        }
    }

    // Update is called once per frame


    // Update is called once per frame
    void Update()
    {
        
    }
}
