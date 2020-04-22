using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PurchaseButton : MonoBehaviour
{
    public static Text errorMessage;
    public TextMeshProUGUI myText;
    public Transform selectCheck;
    //public VisibleItems setVisibleObject;
    public VisibleItems myTest;
    public Transform displaybutton;

    public static List<string> defencesBought = new List<string>();

    public void OnMouseDown()
    {

        selectCheck = GameObject.Find("Selected Card").transform;

        if (PlayGameAssets.cashAmount >= Selected.cardCost) //Checks if finances are enough to purchase
        {
            PlayGameAssets.cashAmount = PlayGameAssets.cashAmount - Selected.cardCost;
            //Money available Text
            PlayGameAssets.moneyTxt = GameObject.Find("Cash").GetComponent<Text>();
            string e = "Cash Amount: " + PlayGameAssets.cashAmount + "k"; //updates current finances
            Debug.Log(e);
            PlayGameAssets.moneyTxt.text = e;

            //Sends cards out of the game after they are purchased
            if (selectCheck.transform.childCount == 0)
            {
                errorMessage = GameObject.Find("ErrorMessage").GetComponent<Text>();
                string p = "Select a Card first!";
                errorMessage.text = p;

                StartCoroutine(DeleteMessage.coroutineA()); //it deletes the displayed message after X seconds
                
            }
            else if (Selected.selected.transform.childCount == 1)
            {
                EndTurn.AdminMessage = GameObject.Find("EndOfTurnMessage").GetComponent<Text>();

                myTest = GameObject.FindObjectOfType(typeof(VisibleItems)) as VisibleItems;
                myTest.DisableItems();
                defencesBought.Add(Selected.cardname);
                //setVisibleObject.DisableItems();

                Debug.Log("We got before the check");
                if (Selected.cardname == "Threat Assessment") // the only card that can be bought multiple times
                {
                    
                    EndTurn.AdminMessage.text = " Organised crime attackers have high skills and clear motivations: they will use advanced attack techniques, such as sophisticated phishing email, Remote Access Tools(RATs) and bespoke malware, in order to steal sensitive data or disrupt a target in subtle ways. Unlike script kiddies who hit indiscriminately all systems that they can reach, such advanced attackers choose specific, valuable targets, which makes their attacks less likely. However, the probability of facing them cannot be underestimated: it would be surprising if at least one of them did not take interest in the company at some point in time." + " " + EndTurn.AdminMessage.text;


                    EndTurn.AdminMessage.text = " Script kiddies have low computer skills: they only use tools built by others and their attack repertoire is limited to simple, known techniques, such as scanning an infrastructure for known vulnerabilities, spreading malware found on the Internet via poorly - written email, or running small Denial of Service attacks with experimental tools.They are motivated by the “fun” aspect of hacking more than anything else.Due to the number of such low-skilled attackers and the wide availability of their techniques, their attacks are expected to be targeting the company’s infrastructure at all times.They are probably already at work as we speak! " + " " + EndTurn.AdminMessage.text;
                    StartCoroutine(DeleteMessage.coroutineC());

                }
                if (Selected.cardname == "Security Training")
                {
                    EndTurn.AdminMessage.text = DeploymentText.SecurityTraining;
                }
                if (Selected.cardname == "Plant Firewall" || Selected.cardname == "Office Firewall")
                {
                    EndTurn.AdminMessage.text = DeploymentText.Firewall;
                }
                if (Selected.cardname == "Network Monitoring O." || Selected.cardname == "Network Monitoring P.")
                {
                    EndTurn.AdminMessage.text = DeploymentText.NetworkMon;
                }
                if (Selected.cardname == "Antivirus")
                {
                    EndTurn.AdminMessage.text = DeploymentText.Antivirus;
                }
                if (Selected.cardname == "Office CCTV" || Selected.cardname == "Plant CCTV")
                {
                    EndTurn.AdminMessage.text = DeploymentText.CCTV;
                }
                if (Selected.cardname == "Server Upgrade")
                {
                    EndTurn.AdminMessage.text = DeploymentText.ServerUpgrade;
                }
                if (Selected.cardname == "Pc Upgrade")
                {
                    EndTurn.AdminMessage.text = DeploymentText.PCUpgrade;
                }
                if (Selected.cardname == "PC Encryption")
                {
                    EndTurn.AdminMessage.text = DeploymentText.PCEncryption;
                }
                if (Selected.cardname == "Controller Upgrade")
                {
                    EndTurn.AdminMessage.text = DeploymentText.ControllerUpgrade;
                }
                if (Selected.cardname == "Database Encryption")
                {
                    EndTurn.AdminMessage.text = DeploymentText.DatabaseEncryption;
                }

                if (Selected.cardname == "Asset Audit")
                {
                    //Recursibely sets active all objects with parent "hand"
                    Selected.hand.gameObject.SetActiveRecursively(true);

                    // and still deletes the selected card
                    Selected.child = Selected.selected.transform.GetChild(0);
                    Destroy(Selected.child.gameObject);
                    EndTurn.AdminMessage.text = DeploymentText.AssetAudit;
                }
                else
                {
                    Selected.child = Selected.selected.transform.GetChild(0);
                    Destroy(Selected.child.gameObject);
                }
                
                StartCoroutine(DeleteMessage.coroutineC());
            }
        }
        else
        {
            errorMessage = GameObject.Find("ErrorMessage").GetComponent<Text>();
            string p = "ERROR, not enough funds";
            errorMessage.text = p;

            StartCoroutine(DeleteMessage.coroutineA());


        }
    }

}
