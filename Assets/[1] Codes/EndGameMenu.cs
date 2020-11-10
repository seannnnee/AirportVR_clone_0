using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    //Method will be called when Restart Level Button is clicked on
    public void restartLevel()
    {
        SceneManager.LoadScene("SampleGameScreen"); //Scene name to be confirmed again
    }

    //Method will be called when Back To Home Button is clicked on
    public void backToHome()
    {
        SceneManager.LoadScene("WelcomeScreen"); //Back to Welcome Screen
    }

    public void quitGame()
    {
        Debug.Log("GAME EXITED!!"); //For testing only, can be removed
        Application.Quit(); //Quit Game
    }
}
