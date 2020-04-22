using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhishingKiddie : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered =false; //If the attack has been countered
    public static string[,] attackCounter = new string[3, 2]; //what counters the attack
    public static string[,] attackCounterEffect = new string[3, 2]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        attackName = "Phishing Kiddie";

        if (PlayGameAssets.currentTurn == 1)
        {
            attackCounter[0, 0] = "Security Training";
            attackCounterEffect[0, 1] = "Upon receiving an email with an attachment from an unknown source, an employee reports it directly to you. Upon close inspection, the attachment did indeed contain malware. Good thing the employee knew better than opening it themselves!";
        }
        if (PlayGameAssets.currentTurn >= 1)
        { 
            attackCounter[1, 0] = "Antivirus";
            attackCounterEffect[1, 1] = "Upon opening an attachment from an unknown sender, the antivirus fires an alert and announces that a malicious program has been stopped from running on the computer. Upon closer inspection, it was indeed a common piece of malware the antivirus stopped just in time: disaster averted!";
        }
        if (PlayGameAssets.currentTurn >= 1 )
        {
            attackCounter[2, 0] = "Pc Upgrade";
            attackCounterEffect[2, 1] = "";
        }

        if (PlayGameAssets.currentTurn >= 2)
        {
            attackEffect = "Employees signal that their machines have stopped functioning and display bizarre messages. You receive a threatening email asking for a 10k ransom in exchange of a decryption key. The board of directors strictly forbids you from paying the ransom. The lost data is never recovered, and the infected machines have to be replaced. The company's share price suffers lightly from the disruption.";
        }

    }
}
