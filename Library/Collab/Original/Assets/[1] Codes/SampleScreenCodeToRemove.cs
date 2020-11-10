using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * THIS CODE ONLY FOR TESTING - TO BE REMOVED IN THE FUTURE
 *
*/

public class SampleScreenCodeToRemove : MonoBehaviour
{
    //Method will be called when Pause Button is clicked on
    public void pauseGame()
    {
        SceneManager.LoadScene("PauseMenu");
    }

    //Method will be called when End Game Button is clicked on
    public void endGame()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
