using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")] //Adds an Object called "Card" to allow a new object to be scripted
public class Card : ScriptableObject
{
    //card variables
    public new string name;
    public string description;

    public Sprite artwork;
    public Sprite background;

    public int cost;

}
