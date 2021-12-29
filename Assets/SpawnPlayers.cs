using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
   public GameObject playerPerfab;

   public float minX;
   public float maxX;
   public float minY;
   public float maxY;
   public float minZ;
   public float maxZ;

   private void Start(){
       Vector3 randomPosition = new Vector3(Random.RandomRange(minX,maxX) , Random.RandomRange(minY,maxY)
        , Random.RandomRange(minZ,maxZ));

        PhotonNetwork.Instantiate(playerPerfab.name, randomPosition , Quaternion.identity);
   }
}
