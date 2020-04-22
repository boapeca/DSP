using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class cardDisplay : MonoBehaviour
{

    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Text costText;

    public Image artworkImage;
    public Image backgroundImage;

    
    // Start is called before the first frame update
    void Start()
    {
        //Displays the different variables in the card in the UI
        nameText.text = card.name;
        descriptionText.text = card.description;
        costText.text = "Cost = £" + card.cost.ToString() +"k";

        artworkImage.sprite = card.artwork;
        backgroundImage.sprite = card.background;

        
       

    }

   
}
