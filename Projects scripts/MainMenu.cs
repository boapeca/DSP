using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour{
   
    public void PlayGame()
    {
        SceneManager.LoadScene(2);


    }
    public void LeaveTut()
    {
        SceneManager.LoadScene(1);
    }

    public void GameAssets()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
