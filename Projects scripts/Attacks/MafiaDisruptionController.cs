using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MafiaDisruptionController : MonoBehaviour
{
    public static string attackName; //Attack name
    public static string attackEffect =""; //The effect on the company
    public static bool attackCountered =false; //If the attack has been countered
    public static string[,] attackCounter = new string[2, 3]; //what counters the attack
    public static string[,] attackCounterEffect = new string[2, 2]; // Shows how the attack was stopped
    public static int turnCountered; //Will point which turn it got countered
    public static string whatCounter; //Assings the variable to which defence stopped this attack

    void Update()
    {
        attackName = "Mafia Disruption Controller";

        if (PlayGameAssets.currentTurn <= 2)
        {
            attackCounter[0, 0] = "Plant Firewall";
            attackCounterEffect[0, 1] = "The firewall intercepts a number of scanning attempts from all over the world. Apparently, there are people out there very interested in knowing more about your plant.";
        }
        if (PlayGameAssets.currentTurn >= 2)
        {
            attackCounter[1, 0] = "Controller Upgrade";
            attackCounterEffect[1, 1] = "";
        }


        if (PlayGameAssets.currentTurn == 3)
        {
            attackEffect = "One day, the turbines suffer from a partial failure, and the damage requires several days of maintenance. Shortly after, you receive a message claiming responsibility for hacking the turbine's controller, and asking for a 500k ransom. The board of directors forbids you from paying anything. The company's share price plummets.";
        }
        if (PlayGameAssets.currentTurn == 4)
        {
            attackEffect = "One day, the turbines start accelerating out of control and finally blow up. Several employees are injured. The company, having lost one of its core assets, is forced to shut down.";
        }

    }
}
