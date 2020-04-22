using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MafiaAPTPCOffices : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered =false; //If the attack has been countered
    public static string[,] attackCounter = new string[4, 3]; //what counters the attack
    public static string[,] attackCounterEffect = new string[4, 3]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        attackName = "Mafia APT PC Office";

        if (PlayGameAssets.currentTurn == 1 || PlayGameAssets.currentTurn == 2)
        {
            attackCounter[0, 0] = "Security Training";
            attackCounterEffect[0, 1] = "Upon finding a thumb drive in the office's parking lot, an employee reports it directly to you. Upon close inspection, the thumb drive did indeed contain malware. Good thing the employee knew better than opening it themselves!";
         }
        if (PlayGameAssets.currentTurn >= 1)
        {
            attackCounter[1, 0] = "Antivirus";
            attackCounterEffect[1, 1] = "Upon plugging in a thumb drive found in the office's parking lot, the antivirus fires an alert and announces that a malicious program has been stopped from running on an office computer. Upon closer inspection, it was indeed a common piece of malware the antivirus stopped just in time: disaster averted!";
        }
        if (PlayGameAssets.currentTurn >= 2)
        {
            attackCounter[2, 0] = "Network Monitoring O.";
            attackCounterEffect[2, 1] = "One day, the office's network administrator comes to talk to you: they have detected suspicious activity on the office network. A PC seems to be communicating at regular intervals with an unknown machine on the Internet, located in a foreign country. Upon closer investigation, the PC was compromised and remotely operated: the administrator makes sure that the link to the attacker's machine is shut down and any malware on the infected target is removed.";
        }
        if (PlayGameAssets.currentTurn >= 1)
        {
            attackCounter[3, 0] = "PC Encryption";
            attackCounterEffect[3, 1] = "";       
        }

        if (PlayGameAssets.currentTurn == 3)
        {
            attackEffect = "A data dump is advertised for sale on the Dark Web, that contains sensitive emails and technical data from the company. The press learns about the data leak, and the company's share price plummets.";
        }
        if (PlayGameAssets.currentTurn == 4)
        {
            attackEffect = "A new data dump is leaked with ever more sensitive content, as well as non-important yet embarrassing personal email. You are forced to shut down the entire infrastructure for sanitisation. The company's share price crashes.";
        }

    }
}
