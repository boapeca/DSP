using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class EndTurn : MonoBehaviour
{

    public Transform boughtChild;
    public DefencesBought defenceTest;
    public TextMeshProUGUI counterText;
    public static Text AdminMessage;
    public static Text attackDisplayed;
    public Color newColor;
    public static String tempMessage;
    public Transform displayBtn;
    public static Transform attackBox;
    public Transform displayEndResults;
    public Text DisplayName;
    public Text DisplayTurn;
    public Text DisplayCounter;

    public void OnMouseDown() //When mouse is clicked on the button
    {
        AdminMessage = GameObject.Find("EndOfTurnMessage").GetComponent<Text>();
        attackDisplayed = GameObject.Find("AttacksDisplayed").GetComponent<Text>();
        displayBtn = GameObject.Find("Display message").transform; //displays the Display button that allow the player to display the AdminMessage again to reread it
        displayBtn.gameObject.SetActiveRecursively(true);

        if (PlayGameAssets.currentTurn >= 4) //Checks if the last turn was the last
        {
            endOfTurnAttacks();
            displayAttacks();
            Debug.Log("Game Over"); // If so, game ends
            StartCoroutine(DeleteMessage.presentResults());
            endGame(); //presents the Final Results
        }
        else
        {
            //Refreshes the cash amount available for the new turn
            PlayGameAssets.cashAmount = PlayGameAssets.cashAmount + 100;
            PlayGameAssets.moneyTxt = GameObject.Find("Cash").GetComponent<Text>();
            string e = "Cash Amount: " + PlayGameAssets.cashAmount + "k";
            Debug.Log(e);
            PlayGameAssets.moneyTxt.text = e;

            endOfTurnAttacks(); //Checks which defences got purchased and displays the according message
            displayAttacks(); //Checks which attacks did not got defences put into place and displays the according message

            PlayGameAssets.currentTurn += 1;
            //Updates Turn Text to the new Turn
            PlayGameAssets.turnTxt = GameObject.Find("Turn Counter").GetComponent<Text>();
            string v = "Turn : " + PlayGameAssets.currentTurn + "/4";
            PlayGameAssets.turnTxt.text = v;
            //returns threat assessment to the card hand
            if (PlayGameAssets.boughtCards.transform.childCount == 1)
            {
                PlayGameAssets.boughtCards.gameObject.active = true;

                boughtChild = PlayGameAssets.boughtCards.transform.GetChild(0);
                boughtChild.transform.SetParent(Selected.hand);
                boughtChild.transform.SetParent(Selected.hand, false);
            }
        }       
    }
    public void endOfTurnAttacks()
    {
        AdminMessage.text = "";
        Debug.Log("We got here");
        for (int i = 0; i < PurchaseButton.defencesBought.Count; i++)
        {           
            if (PurchaseButton.defencesBought[i] == ScanningKiddie.attackCounter)
            {
                if (ScanningKiddie.attackCountered == true)
                {
                }
                else
                {
                    Debug.Log("1");
                    ScanningKiddie.attackCountered = true;
                    AdminMessage.text = "Admin Message: " + ScanningKiddie.attackCounterEffect + " \n " +  AdminMessage.text + "   \n   " + "   \n   ";
                    ScanningKiddie.turnCountered = PlayGameAssets.currentTurn;
                    ScanningKiddie.whatCounter = ScanningKiddie.attackCounter;
                }
            }
            if (PurchaseButton.defencesBought[i] == DoSKiddie.attackCounter && (PlayGameAssets.currentTurn >= 2))
            {
                if (DoSKiddie.attackCountered == true)
                {
                }
                else
                {
                    Debug.Log(HackingKiddie.attackCounter[0, 0]);
                    Debug.Log(PurchaseButton.defencesBought[i] + " + " + DoSKiddie.attackCounter);
                    DoSKiddie.attackCountered = true;
                    AdminMessage.text = "  Admin Message: " + DoSKiddie.attackCounterEffect + "  \n " + AdminMessage.text + "   \n   " + "   \n   ";
                    DoSKiddie.turnCountered = PlayGameAssets.currentTurn;
                    DoSKiddie.whatCounter = DoSKiddie.attackCounter;
                }    
            }
            
            if ((PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[1, 0]) || (PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[2, 0]))
            {
                Debug.Log("Test");
                Debug.Log(PurchaseButton.defencesBought[i]);
                if (HackingKiddie.attackCountered == true)
                {
                }
                else
                {
                    HackingKiddie.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[0, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + HackingKiddie.attackCounterEffect[0,1] + "  \n " + AdminMessage.text + "   \n   ";
                        HackingKiddie.whatCounter = HackingKiddie.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[1, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + HackingKiddie.attackCounterEffect[1,1] + "  \n " + AdminMessage.text + "  \n    ";
                        HackingKiddie.whatCounter = HackingKiddie.attackCounter[1, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == HackingKiddie.attackCounter[2, 0])
                    { 
                        AdminMessage.text ="  Admin Message: " + HackingKiddie.attackCounterEffect[2,1] + "  \n " + AdminMessage.text + "   \n   ";
                        HackingKiddie.whatCounter = HackingKiddie.attackCounter[2, 0];
                    }
                    HackingKiddie.turnCountered = PlayGameAssets.currentTurn;
                }
            }
            if ((PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[1, 0]) || (PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[2, 0]))
            {
                if (PhishingKiddie.attackCountered == true)
                {
                }
                else
                {

                    PhishingKiddie.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[0, 0])
                    {
                        AdminMessage.text =  "  Admin Message: " + PhishingKiddie.attackCounterEffect[0, 1] + " \n  " + AdminMessage.text + "   \n   ";
                        PhishingKiddie.whatCounter = PhishingKiddie.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[1, 0])
                    {
                        AdminMessage.text =  "  Admin Message: " + PhishingKiddie.attackCounterEffect[1, 1] + "  \n " + AdminMessage.text + "  \n    ";
                        PhishingKiddie.whatCounter = PhishingKiddie.attackCounter[1, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == PhishingKiddie.attackCounter[2, 0])
                    {
                        PhishingKiddie.whatCounter = PhishingKiddie.attackCounter[2, 0];
                    }

                    PhishingKiddie.turnCountered = PlayGameAssets.currentTurn;
                }
            }
            if ((PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[1, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[2, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[3, 0]))
            {
                if (MafiaAPTPCOffices.attackCountered == true)
                {
                }
                else
                {
                    MafiaAPTPCOffices.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[0, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTPCOffices.attackCounterEffect[0, 1] + "  \n " + AdminMessage.text + "  \n    ";
                        MafiaAPTPCOffices.whatCounter = MafiaAPTPCOffices.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[1, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTPCOffices.attackCounterEffect[1, 1] + " \n  " + AdminMessage.text + "   \n   ";
                        MafiaAPTPCOffices.whatCounter = MafiaAPTPCOffices.attackCounter[1, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[2, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTPCOffices.attackCounterEffect[2, 1] + "  \n " + AdminMessage.text + "   \n   ";
                        MafiaAPTPCOffices.whatCounter = MafiaAPTPCOffices.attackCounter[2,0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTPCOffices.attackCounter[3, 0])
                    {
                        MafiaAPTPCOffices.whatCounter = MafiaAPTPCOffices.attackCounter[3, 0];
                    }
                    MafiaAPTPCOffices.turnCountered = PlayGameAssets.currentTurn;
                }
            }
            if ((PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[1, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[2, 0]))
            {
                if (MafiaAPTServerOffices.attackCountered == true)
                {
                }
                else
                {

                    MafiaAPTServerOffices.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[0, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTServerOffices.attackCounterEffect[0, 1] + "  \n " + AdminMessage.text + "   \n   ";
                        MafiaAPTServerOffices.whatCounter = MafiaAPTServerOffices.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[1, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTServerOffices.attackCounterEffect[1, 1] + " \n  " + AdminMessage.text + "  \n    ";
                        MafiaAPTServerOffices.whatCounter = MafiaAPTServerOffices.attackCounter[1, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerOffices.attackCounter[2, 0])
                    {
                        MafiaAPTServerOffices.whatCounter = MafiaAPTServerOffices.attackCounter[2, 0];
                    }
                    MafiaAPTServerOffices.turnCountered = PlayGameAssets.currentTurn;
                }
            }
            if ((PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[1, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[2, 0]) || (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[3, 0]))
            {
                if (MafiaAPTServerPlant.attackCountered == true)
                {
                }
                else
                {
                    MafiaAPTServerPlant.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[0, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTServerPlant.attackCounterEffect[0, 1] + " \n  " + AdminMessage.text + "  \n    ";
                        MafiaAPTServerPlant.whatCounter = MafiaAPTServerPlant.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[2, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaAPTServerPlant.attackCounterEffect[2, 1] + "  \n " + AdminMessage.text + "   \n   ";
                        MafiaAPTServerPlant.whatCounter = MafiaAPTServerPlant.attackCounter[2, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[1, 0])
                    {
                        MafiaAPTServerPlant.whatCounter = MafiaAPTServerPlant.attackCounter[1, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaAPTServerPlant.attackCounter[3, 0])
                    {
                        MafiaAPTServerPlant.whatCounter = MafiaAPTServerPlant.attackCounter[3, 0];
                    }

                    MafiaAPTServerPlant.turnCountered = PlayGameAssets.currentTurn;
                }
            }
            if ((PurchaseButton.defencesBought[i] == MafiaDisruptionController.attackCounter[0, 0]) || (PurchaseButton.defencesBought[i] == MafiaDisruptionController.attackCounter[1, 0]))
            {
                
                if (MafiaDisruptionController.attackCountered == true)
                {
                }
                else
                {
                    MafiaDisruptionController.attackCountered = true;
                    if (PurchaseButton.defencesBought[i] == MafiaDisruptionController.attackCounter[0, 0])
                    {
                        AdminMessage.text = "  Admin Message: " + MafiaDisruptionController.attackCounterEffect[0, 1] + "  \n " + AdminMessage.text + "   \n   ";
                        MafiaDisruptionController.whatCounter = MafiaDisruptionController.attackCounter[0, 0];
                    }
                    if (PurchaseButton.defencesBought[i] == MafiaDisruptionController.attackCounter[1, 0])
                    {
                        MafiaDisruptionController.whatCounter = MafiaDisruptionController.attackCounter[1, 0];
                    }
                    MafiaDisruptionController.turnCountered = PlayGameAssets.currentTurn;
                }
            }
        }
        tempMessage = AdminMessage.text;
        StartCoroutine(DeleteMessage.coroutineB());
    }

    public void displayAttacks()
    {
        if (ScanningKiddie.attackCountered == false && ScanningKiddie.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + ScanningKiddie.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }

        if (PhishingKiddie.attackCountered == false && PhishingKiddie.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + PhishingKiddie.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }

        if (MafiaAPTPCOffices.attackCountered == false && MafiaAPTPCOffices.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + MafiaAPTPCOffices.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }
        if (MafiaAPTServerOffices.attackCountered == false && MafiaAPTServerOffices.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + MafiaAPTServerOffices.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }
        if (MafiaAPTServerPlant.attackCountered == false && MafiaAPTServerPlant.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + MafiaAPTServerPlant.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }
        if (MafiaDisruptionController.attackCountered == false && MafiaDisruptionController.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + MafiaDisruptionController.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }
        if (HackingKiddie.attackCountered == false && HackingKiddie.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + HackingKiddie.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }
        if (DoSKiddie.attackCountered == false && DoSKiddie.attackEffect != "")
        {
            attackDisplayed.text = " WARNING : " + DoSKiddie.attackEffect + "  " + attackDisplayed.text;
            attackDisplayed.gameObject.SetActiveRecursively(true);
            StartCoroutine(DeleteMessage.coroutineD());
            
        }

        
    }

    
    public void endGame()
    {

        displayEndResults = GameObject.Find("Canvas").transform;
        displayEndResults.gameObject.active = false;

        displayEndResults = GameObject.Find("CheckObject").transform;
        displayEndResults.gameObject.SetActiveRecursively(true);

        //Display Scanning Kiddie
        DisplayName = GameObject.Find("ScanningKiddieR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("SKR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("SKR C").GetComponent<Text>();
        DisplayName.text = ScanningKiddie.attackName;
        DisplayTurn.text = ScanningKiddie.turnCountered.ToString();
        DisplayCounter.text = ScanningKiddie.whatCounter;

        //Display DoS Kiddie
        DisplayName = GameObject.Find("DoSKiddieR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("DOSKR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("DOSKR C").GetComponent<Text>();
        DisplayName.text = DoSKiddie.attackName;
        DisplayTurn.text = DoSKiddie.turnCountered.ToString();
        DisplayCounter.text = DoSKiddie.whatCounter;

        //Display Hacking Kiddie
        DisplayName = GameObject.Find("HackingKiddieR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("HKR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("HKR C").GetComponent<Text>();
        DisplayName.text = HackingKiddie.attackName;
        DisplayTurn.text = HackingKiddie.turnCountered.ToString();
        DisplayCounter.text = HackingKiddie.whatCounter;

        //Display Phishing Kiddie
        DisplayName = GameObject.Find("PhishingKiddieR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("PKR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("PKR C").GetComponent<Text>();
        DisplayName.text = PhishingKiddie.attackName;
        DisplayTurn.text = PhishingKiddie.turnCountered.ToString();
        DisplayCounter.text = PhishingKiddie.whatCounter;

        //Display Mafia APT PC Offices
        DisplayName = GameObject.Find("MafiaPCOfficeR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("MPCOR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("MPCOR C").GetComponent<Text>();
        DisplayName.text = MafiaAPTPCOffices.attackName;
        DisplayTurn.text = MafiaAPTPCOffices.turnCountered.ToString();
        DisplayCounter.text = MafiaAPTPCOffices.whatCounter;

        //Display Mafia APT Server Office
        DisplayName = GameObject.Find("MafiaServerOfficeR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("MSOR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("MSOR C").GetComponent<Text>();
        DisplayName.text = MafiaAPTServerOffices.attackName;
        DisplayTurn.text = MafiaAPTServerOffices.turnCountered.ToString();
        DisplayCounter.text = MafiaAPTServerOffices.whatCounter;

        //Display Mafia APT Server Plant
        DisplayName = GameObject.Find("MafiaServerPlantR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("MSPR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("MSPR C").GetComponent<Text>();
        DisplayName.text = MafiaAPTServerPlant.attackName;
        DisplayTurn.text = MafiaAPTServerPlant.turnCountered.ToString();
        DisplayCounter.text = MafiaAPTServerPlant.whatCounter;

        //Display Mafia Disruption controller
        DisplayName = GameObject.Find("MafiaDisruptionControllerR").GetComponent<Text>();
        DisplayTurn = GameObject.Find("MDCR").GetComponent<Text>();
        DisplayCounter = GameObject.Find("MDCR C").GetComponent<Text>();
        DisplayName.text = MafiaDisruptionController.attackName;
        DisplayTurn.text = MafiaDisruptionController.turnCountered.ToString();
        DisplayCounter.text = MafiaDisruptionController.whatCounter;

        /*
         * //Display 
        DisplayName = GameObject.Find("").GetComponent<Text>();
        DisplayTurn = GameObject.Find("").GetComponent<Text>();
        DisplayCounter = GameObject.Find("").GetComponent<Text>();
        DisplayName.text = .attackName;
        DisplayTurn.text = .turnCountered.ToString();
        DisplayCounter.text = .whatCounter;
        */





    }
}
