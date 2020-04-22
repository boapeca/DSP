using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    
    public Transform parentToReturnTo = null;
   
    public void OnBeginDrag(PointerEventData eventData) // Starts the Drag event of an object
    {
        Debug.Log("Begin");

        parentToReturnTo = this.transform.parent; // assing the parent where the card should return to
        this.transform.SetParent(this.transform.parent.parent);


    }

    public void OnDrag(PointerEventData eventData) //While dragging
    {
        Debug.Log("Drag");
        this.transform.position = eventData.position; //Updates card position to the mouse position
    }

    public void OnEndDrag(PointerEventData eventData) //When drag stops
    {
        Debug.Log("END");
        this.transform.SetParent(parentToReturnTo); //Returns the card back to the Hand pile
    }
}
