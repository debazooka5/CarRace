using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;

    public GameObject player2;

    public GameObject player3;
    public static GameObject player;

private void Awake() {
    Vector3 rot=new Vector3(0,45,0);
    var a= PlayerPrefs.GetInt("carnumber");

    Debug.Log(a+"car number");

    if(a==0){
        player=Instantiate(player1,Vector3.zero,Quaternion.Euler(rot));
    }
    if(a==1){
        player=Instantiate(player2,Vector3.zero,Quaternion.Euler(rot));
    }
    if(a==2){
       player=Instantiate(player3,Vector3.zero,Quaternion.Euler(rot));
    }
   // GameObject player123=Instantiate(player3,Vector3.zero,Quaternion.identity);
}
}
