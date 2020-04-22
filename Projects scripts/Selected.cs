using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Selected : MonoBehaviour
{

    public static Transform child;

    public static Transform selected;
    public static Transform hand;
    public static int cardCost;
    public static string cardname;
    




    //Invoked when a button is clicked.
    public void MouseClick(Transform newParent)
    {
        selected = GameObject.Find("Selected Card").transform;
        hand = GameObject.Find("My Hand").transform;
        

        cardDisplay go = this.GetComponent<cardDisplay>();
        cardCost = go.card.cost;
        cardname = go.card.name;
        
        if (selected.transform.childCount == 0) // Checks if it has children
        {
            Debug.Log("== null Works"); //check which part of the if statment is being called
            Debug.Log("name is : " + selected.transform.name);
            this.transform.SetParent(null);

            // Sets the Selected Card as the new parent for the card
            this.transform.SetParent(selected);

            // Gets the card in the same position as Selected Card Group
            this.transform.SetParent(selected, false);
        }
        else
        {
            Debug.Log("!= null Works"); //check which part of the if statment is being called
            /*
             * If there is a child already in Selected Card is sends it to My Hand before selecting a new card
             */
            child = selected.transform.GetChild(0);
            child.transform.SetParent(hand);
            child.transform.SetParent(hand, false);
            

            this.transform.SetParent(null);
            // Sets the Selected card as the new parent for the card
            this.transform.SetParent(selected);
            // Gets the card in the same position as Selected Card
            this.transform.SetParent(selected, false);

        }      
    }
    
        

 }




