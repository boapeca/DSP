using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VisibleItems : MonoBehaviour
{
    
    public Transform game;
    public Transform itemCheck;
    public Transform newParent;
    public Transform disable;

    
    //Here we will check which card was purchased and make the correspondent object appear on the board
    public void DisableItems()
    {
        //assign differen variables that will be needed to assing new parents and make the item visible
        game = GameObject.Find("Board Game").transform;
        newParent = GameObject.Find("Active Items").transform;

        game.gameObject.SetActiveRecursively(true); //enables all objects under Game Board
        disable = GameObject.Find("Disabled Items").transform;


        if (Selected.cardname == "Antivirus")
        {
            itemCheck = GameObject.Find("Antivirus").transform; //finds object named antivirus
            itemCheck.transform.SetParent(newParent); // assigns new parent to Visible Objects

        }
        if (Selected.cardname == "Pc Upgrade")
        {
            itemCheck = GameObject.Find("PC Upgrade").transform;
            itemCheck.transform.SetParent(newParent);

            newParent = GameObject.Find("Disabled Items").transform;
            itemCheck = GameObject.Find("Original PCs").transform;

            itemCheck.transform.SetParent(newParent);

            

        }
        if (Selected.cardname == "Plant CCTV")
        {
            itemCheck = GameObject.Find("Plant CCTV").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Office CCTV")
        {
            itemCheck = GameObject.Find("Office CCTV").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Plant Firewall")
        {
            itemCheck = GameObject.Find("Plant Firewall").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Office Firewall")
        {
            itemCheck = GameObject.Find("Office Firewall").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Network Monitoring O.")
        {
            itemCheck = GameObject.Find("Office Mon").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Network Monitoring P.")
        {
            itemCheck = GameObject.Find("Plant Mon").transform;
            itemCheck.transform.SetParent(newParent);

           

        }

        if (Selected.cardname == "Server Upgrade")
        {
            itemCheck = GameObject.Find("Server upgrade").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Database Encryption")
        {
            itemCheck = GameObject.Find("Database Upgrade").transform;
            itemCheck.transform.SetParent(newParent);

            

        }

        if (Selected.cardname == "Controller Upgrade")
        {
            itemCheck = GameObject.Find("Controller").transform;
            itemCheck.transform.SetParent(newParent);

            

        }
        disable.gameObject.active = false; //Disables the rest of the objects not selected
        return;
        
        

    }
    
}
