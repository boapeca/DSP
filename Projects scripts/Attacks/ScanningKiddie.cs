using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanningKiddie : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect; //The effect on the company
    public static bool attackCountered; //If the attack has been countered
    public static string attackCounter; //What counters the attack
    public static string attackCounterEffect; //Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Start()
    {
        attackName = "Scanning Kiddie";
        if (PlayGameAssets.currentTurn >= 1)
        {
            attackEffect = "";
            attackCounter = "Office Firewall";
            attackCounterEffect = "The office firewall intercepts a number of scanning attempts from all over the world. Apparently, there are people out there very interested in knowing more about your office network.";

        }
        
    }

}
