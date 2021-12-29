using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class inputUi : MonoBehaviour
{
    public InputField roomName;

    public void MyDemoButton()
    {
        Debug.Log(roomName.text);
    }
    
}
