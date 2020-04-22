using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MafiaAPTServerPlant : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered = false; //If the attack has been countered
    public static string[,] attackCounter = new string[4, 3]; //what counters the attack
    public static string[,] attackCounterEffect = new string[4, 2]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        
        attackName = "Mafia APT Server Plant";

        if (PlayGameAssets.currentTurn == 1)
        {
            attackCounter[0, 0] = "Asset Audit";
            attackCounterEffect[0, 1] = "During the asset audit, an unsecured, undocumented Wi-Fi network was found in the plant. After some investigation, this was set up years ago by an engineer, who is now retired. They needed to install a set of additional debit sensors on the water stream, and an open Wi-Fi network was a cheap and simple solution compared to deploying a complicated set of cables. The Wi-Fi network was never documented and eventually forgotten. It has now been secured with a strong password.";
        }
        if (PlayGameAssets.currentTurn >= 3)
        {
            attackCounter[1, 0] = "Database Encryption";
            attackCounterEffect[1, 1] = "";
        }
        if (PlayGameAssets.currentTurn >= 2)
        {
            attackCounter[2, 0] = "Network Monitoring O.";
            attackCounterEffect[2, 1] = "One day, the office's network administrator comes to talk to you: they have detected suspicious activity on the plant network. The historian database seems to be communicating at regular intervals with an unknown machine on the Internet, located in a foreign country. Upon closer investigation, the historian was compromised and remotely operated: the administrator makes sure that the link to the attacker's machine is shut down and any malware on the historian is removed.";    
        }

        if (PlayGameAssets.currentTurn == 1)
        {
            attackCounter[3, 0] = "Server Upgrade";
            attackCounterEffect[3, 1] = "";
        }


        if (PlayGameAssets.currentTurn == 3)
        {
            attackEffect = "One of your competitors alerts you that someone is trying to sell sensitive data apparently stolen from your plant database. Shortly after, the story leaks to the press. The company's share price plummets.";
         }
        if (PlayGameAssets.currentTurn == 4)
        {
            attackEffect = "One day, the plant database crashes, and recovery attempts reveal that the entire contents have been corrupted. All activities slow down significantly for a few days, as the company's share price takes another dive.";
         }

    }
}
