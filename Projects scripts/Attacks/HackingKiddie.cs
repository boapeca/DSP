using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingKiddie : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered = false; //If the attack has been countered
    public static string[,] attackCounter = new string[3, 2]; //what counters the attack
    public static string[,] attackCounterEffect = new string[3, 2]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        attackName = "Hacking Kiddie";

        if (PlayGameAssets.currentTurn == 2)
        {
            attackEffect = "";
            attackCounter[0, 0] = "Server Upgrade";
            attackCounterEffect[0,1] = "The logs of the server show that someone on the Internet tried to use an SQL injection to compromise the server. This would have affected the old version of the software, but fortunately, the vulnerability has been patched.";
        }
        if (PlayGameAssets.currentTurn >= 3)
        {
            attackEffect = "You receive a snarky email written in an approximate language and taunting the company for their poor security.Soon after, the company's email database is published on the Internet, and the press learns about the breach. The company's share price takes a small dip.";
            attackCounter[1,0] = "Network Monitoring O.";
            attackCounterEffect[1,1] = "One day, the office's network administrator comes to talk to you: they have detected a suspicious data stream originating from the database and going to an unknown address on the Internet, located in a foreign country. Upon closer investigation, it was a data exfiltration attack: the administrator makes sure that the link to the attacker's machine is shut down and any malware on the infected target is removed.";
            
            attackCounter[2, 0] = "Database Encryption";
            attackCounterEffect[2, 1] = "";
        }
        
    }
}
