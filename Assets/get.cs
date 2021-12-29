using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get : MonoBehaviour
{
    [SerializeField] string Trigger;
    public GameObject UiObject;
    private bool flag = false;
    private bool Key;
    //private GameObject other;

    public bool GetKey()
    {
        return Key;
    }

    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Trigger)
        {
            //this.other = other.gameObject;
            UiObject.SetActive(true);
            flag = true;
         }

    }
    public void SetKey(bool flag)
    {
        this.Key = flag;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && flag)
        {
            Destroy(this.gameObject);
            SetKey(true);
            Debug.Log(Key);
            UiObject.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        flag = false;
    }
}
