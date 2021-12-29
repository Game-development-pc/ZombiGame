using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTrigger : MonoBehaviour
{
    [SerializeField] int lives = 3;
    // Start is called before the first frame update
   [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled) {
            if(lives == 0){
            Destroy(other.gameObject);
            for(int i = 3; i > 0; i++){

            }
            SceneManager.LoadScene(4);
            }
            lives--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
