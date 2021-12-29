using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnZombies : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject zombiePerfab;

  public int zomeisNumber;

   public float minX;
   public float maxX;
   public float minY;
   public float maxY;
   public float minZ;
   public float maxZ;

protected virtual GameObject spawnObject() {
    Vector3 randomPosition = new Vector3(Random.RandomRange(minX,maxX) , Random.RandomRange(minY,maxY)
        , Random.RandomRange(minZ,maxZ));
        GameObject newZombie = Instantiate(zombiePerfab,randomPosition,zombiePerfab.transform.rotation);

        return newZombie;
}

private void numberOfZombies(int zombieNum){
    for(int i  = 0; i < zombieNum; i ++){
        spawnObject();
    }
}
   private void Start(){
       numberOfZombies(zomeisNumber);
   }
}
