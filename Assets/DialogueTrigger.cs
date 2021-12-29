using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject UiObject;
    public GameObject Uitext;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
            Uitext.SetActive(true);
            TriggerDialogue();
            
        }

    }
    void Start()
    {
        UiObject.SetActive(false);
        Uitext.SetActive(false);
    }
   
    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
    }
}
