using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayGameAssets : MonoBehaviour
{
    

    // Start is called before the first frame update
    public static Text turnTxt;
    public static int currentTurn = 1;
    public static int cashAmount = 100; 
    public static Text moneyTxt;
    public static Transform boughtCards;
    public static Transform card10;
    public static Transform card11;
    public static Transform card12;
    public static Transform card13;
    public static Transform card14;

    public static Transform originalPC;
    public static Transform upgradePC;
    public static Transform antivirus;
    public static Transform plantCCTV;
    public static Transform officeCCTV;
    public static Transform databaseUp;
    public static Transform plantFire;
    public static Transform officeFire;
    public static Transform officeNetMon;
    public static Transform plantNetMon;
    public static Transform serverUp;

    public static Transform boardGame;


    void Start()
    {
        //Presents the texts needed when game loads
        //Turn counter Text
        turnTxt = GameObject.Find("Turn Counter").GetComponent<Text>();
        string v = "Turn : " + currentTurn + "/4";
        Debug.Log(v);
        turnTxt.text = v;

        //Money available Text
        moneyTxt = GameObject.Find("Cash").GetComponent<Text>();
        string e = "Cash Amount: " + cashAmount + "k";
        Debug.Log(e);
        moneyTxt.text = e;

        //assigns the parent Cards Bought to boughtCards
        boughtCards = GameObject.Find("CardsBought").transform;

        boardGame = GameObject.Find("Board Game").transform;

        /* in case it's needed
        //assigns the objects to variables to be accessed later
        // .Find find the object in the scene with the name provived
        originalPC = GameObject.Find("Original PCs").transform;
        upgradePC = GameObject.Find("PC Upgrade").transform;
        antivirus = GameObject.Find("Antivirus").transform;
        plantCCTV = GameObject.Find("Plant CCTV").transform;
        officeCCTV = GameObject.Find("Office CCTV").transform;
        databaseUp = GameObject.Find("Database Upgrade").transform;
        plantFire = GameObject.Find("Plant Firewall").transform;
        officeFire = GameObject.Find("Office Firewall").transform;
        officeNetMon = GameObject.Find("Office Net Monitoring").transform;
        plantNetMon = GameObject.Find("Plant Net Monitoring").transform;
        serverUp = GameObject.Find("Server upgrade").transform;


        

        upgradePC.gameObject.SetActive(true);
        antivirus.gameObject.SetActive(true);
        plantCCTV.gameObject.SetActive(true);
        officeCCTV.gameObject.SetActive(true);
        databaseUp.gameObject.SetActive(true);
        plantFire.gameObject.SetActive(true);
        officeFire.gameObject.SetActive(true);
        officeNetMon.gameObject.SetActive(true);
        plantNetMon.gameObject.SetActive(true);
        serverUp.gameObject.SetActive(true);
        */
    }

   


}
