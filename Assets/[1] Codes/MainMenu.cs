using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Method will be called when Play Button is clicked on
    public void startGame()
    {
        SceneManager.LoadScene("SelectAirport"); //Scene name to be changed
    }

    //Method will be called when Quit Button is clicked on
    public void endGame()
    {
        Debug.Log("GAME EXITED!!"); //For testing only, can be removed
        Application.Quit(); //Quit Game
    }
}
