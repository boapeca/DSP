using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ShowMessageAgain : MonoBehaviour
{
    public void OnMouseDown() //When mouse is clicked on the button
    {
        EndTurn.AdminMessage.text = EndTurn.tempMessage;
        StartCoroutine(DeleteMessage.coroutineB());
    }
}

