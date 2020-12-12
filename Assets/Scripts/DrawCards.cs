//sing MediaKeySystemAccess.Collections;
//using MediaKeySystemAccess.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{

    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerFeldWesten;
    public GameObject PlayerFeldNorden;
    public GameObject PlayerFeldOsten;
    public GameObject PlayerFeldSueden;
     
     void Start() 
     {

     }

     public void OnClick() {
        for ( var i = 0; i < 5; i++) { // 5 bis Karten

        GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerFeldNorden.transform, false); 
        playerCard.transform.SetParent(PlayerFeldWesten.transform, false);
        playerCard.transform.SetParent(PlayerFeldOsten.transform, false);

         // transform entscheidet, wo die Karten gespeichert werden sollen, in diesem Fall im suedlichen Feld
        playerCard.transform.SetParent(PlayerFeldSueden.transform, false);  
        }
     }
}