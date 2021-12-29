using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text DialogueText;
    public get get;
    public GetVaccine vaccine;
    public Animator animator;

    private Queue<string> sentensces;
    private Queue<string> sentensces2;


    // Start is called before the first frame update
    void Start()
    {
        sentensces = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        Debug.Log("Starting conversation ");

        sentensces.Clear();

        //foreach (string sentensce in dialogue.sentensces)
        string sentensce;
        if (vaccine.GetKey() == false)
        {
            for (int i = 0; i < 3; i++)
            {
                sentensce = dialogue.sentensces[i];
                sentensces.Enqueue(sentensce);
            }
        }
        else
        {
            for (int i = 3; i < dialogue.sentensces.Length; i++)
            {
                sentensce = dialogue.sentensces[i];
                sentensces.Enqueue(sentensce);
            }
        }

        
        StartCoroutine(Delay());
        
    }

    public void DisplayNextSentensce()
    {
        if (sentensces.Count == 0)
        {
            EndDialogue();
            return;
        }
        //if (Key == false)
        //{
            string sentensce = sentensces.Dequeue();
            //StopAllCoroutines();
            //StartCoroutine(TypeSentence(sentensce));
            DialogueText.text = sentensce;
            Debug.Log(sentensce);
            Debug.Log(get.GetKey());
        //}
    }
    private IEnumerator Delay()
    {

        while (true)
        {
            DisplayNextSentensce();
            yield return new WaitForSeconds(8F);
        }

    }

    IEnumerator TypeSentence (string sentence)
    {
        
        DialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(1 / 10F);
        }

    }

    void EndDialogue()
    {
        StopAllCoroutines();
        //Debug.Log("End of conversation. ");
        animator.SetBool("IsOpen", false);
    }


}
