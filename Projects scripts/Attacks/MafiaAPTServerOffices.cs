using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MafiaAPTServerOffices : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered = false; //If the attack has been countered
    public static string[,] attackCounter = new string[3, 3]; //what counters the attack
    public static string[,] attackCounterEffect = new string[3, 2]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        attackName = "Mafia APT Server Office";

        if (PlayGameAssets.currentTurn == 1)
        {
            attackCounter[0, 0] = "Security Training";
            attackCounterEffect[0, 1] = "Upon receiving an email with an attachment from an unknown source, your server administrator reports it directly to you. Upon close inspection, the attachment did indeed contain malware. Good thing they knew better than opening it themselves!";
        }
        if (PlayGameAssets.currentTurn >= 3)
        {
            attackCounter[1, 0] = "Database Encryption";
            attackCounterEffect[1, 1] = "";
        }
        if (PlayGameAssets.currentTurn >= 2)
        {
            attackCounter[2, 0] = "Network Monitoring O.";
            attackCounterEffect[2, 1] = "One day, the office's network administrator comes to talk to you: they have detected suspicious activity on the office network. The server seems to be communicating at regular intervals with an unknown machine on the Internet, located in a foreign country. Upon closer investigation, the server was compromised and remotely operated: the administrator makes sure that the link to the attacker's machine is shut down and any malware on the infected target is removed.";
        }
        

        if (PlayGameAssets.currentTurn == 3)
        {
            attackEffect = "A data dump is put on sale on the Dark Web containing sensitive data from the company: email, HR records, client contracts, and banking details. The press learns about the data leak and the company's share price plummets";
        }
        if (PlayGameAssets.currentTurn == 4)
        {
            attackEffect = "A cryptolocker locks down the content of the office database. As all activity has to be stopped in the office, since no one can work without access to the database, you receive a chilling email asking for a 500k ransom. The board of directors refuses to pay any ransom, and the company, having lost one of its core assets, is forced to shut down.";
        }

    }
}
