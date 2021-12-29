using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;


public class connectToServer : MonoBehaviourPunCallbacks
{
     bool isConnecting;
     public InputField joinInput;
      public InputField createInput;

    // Start is called before the first frame update
    private void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    }
      void Awake()
        {
            // #Critical
            // this makes sure we can use PhotonNetwork.LoadLevel() on the master client and all clients in the same room sync their level automatically
            PhotonNetwork.AutomaticallySyncScene = true;
        }


     public void Connect()
        {
             PhotonNetwork.ConnectUsingSettings();
              PhotonNetwork.GameVersion = "1";
            // // we check if we are connected or not, we join if we are , else we initiate the connection to the server.
            // if (PhotonNetwork.IsConnected)
            // {
            //     // #Critical we need at this point to attempt joining a Random Room. If it fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
            //     PhotonNetwork.JoinRandomRoom();
            // }
            // else
            // {
            //     // #Critical, we must first and foremost connect to Photon Online Server.
            //     isConnecting = PhotonNetwork.ConnectUsingSettings();
            //     PhotonNetwork.GameVersion = "1";
            // }
        }
    public override void OnConnectedToMaster()
    {
        //PhotonNetwork.JoinLobby();
         PhotonNetwork.JoinRandomRoom();
        Debug.Log("Connected");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
        {
          PhotonNetwork.CreateRoom(null, new RoomOptions {MaxPlayers = 4});
        }

    public override void OnJoinedLobby(){
        SceneManager.LoadScene(0);
    }
 public override void OnJoinedRoom()
        {
            
                PhotonNetwork.LoadLevel(2);
   
        }
}