using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
 * THIS CODE ONLY FOR TESTING - TO BE REMOVED IN THE FUTURE
 *
*/

public class SampleScreenCodeToRemove : MonoBehaviour
{
    public TextMeshProUGUI playerType;

    void Start()
    {
        string playerRole = GameMenu.role;
        string playerAirport = SelectAirportMenu.selectedAirport;
        playerType.text = "You selected to play " + playerRole + " in " + playerAirport;
    }

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
