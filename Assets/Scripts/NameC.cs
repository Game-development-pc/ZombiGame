using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameC : MonoBehaviour
{
    
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text = "Welcome" + theName + "to the game";
    }
}
