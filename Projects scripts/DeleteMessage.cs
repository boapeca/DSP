using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMessage : MonoBehaviour
{
    public static EndTurn check;
   public static IEnumerator coroutineA()
    {
        yield return new WaitForSeconds(2.0f);
        PurchaseButton.errorMessage.text = "";
        
    }

    public static IEnumerator coroutineB()
    {
        yield return new WaitForSeconds(20.0f);
        EndTurn.AdminMessage.text = "";
    }

    public static IEnumerator coroutineC()
    {
        yield return new WaitForSeconds(50.0f);
        EndTurn.AdminMessage.text = "";
    }

    public static IEnumerator coroutineD()
    {
        EndTurn.attackBox = GameObject.Find("AttacksCanvas").transform;

        yield return new WaitForSeconds(25.0f);
        EndTurn.attackDisplayed.text = "";

        EndTurn.attackBox.gameObject.active = false;
    }

    public static IEnumerator presentResults()
    {
        yield return new WaitForSeconds(5.0f);
        
        

    }

}
