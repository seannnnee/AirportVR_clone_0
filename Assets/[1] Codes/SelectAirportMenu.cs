using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectAirportMenu : MonoBehaviour
{
    public static string selectedAirport = "No Airport Selected";

    public void tokyoAirportSelected()
    {
        selectedAirport = "Tokyo Airport";
        SceneManager.LoadScene("SelectRole");
    }

    public void changiAirportSelected()
    {
        selectedAirport = "Changi Airport";
        SceneManager.LoadScene("SelectRole");
    }
}
