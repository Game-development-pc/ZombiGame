using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class mineCamera : MonoBehaviourPun
{
    public Camera Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine){
           Player.enabled = true;
        }
    }
}
