using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenu : MonoBehaviour
{
    //SelectAirportMenu airportType;
    //public TMP_Text selection;
    public static string role = "";

    //string airport = "You selected " + SelectAirportMenu.selectedAirport.ToString();
    
    //public void Start() {
        //airportType = GameObject.Find("selectedAirport").GetComponent<SelectAirportMenu>();
        //selection.text = airport;
    //}

    //Method will be called when Pilot is clicked on
    public void pilotScene()
    {
        SceneManager.LoadScene("SampleGameScreen"); //SAMPLE ONLY, TO BE REMOVED
        role = "Pilot";
    }

    //Method will be called when Baggage Truck is clicked on
    public void baggageTruckScene()
    {
        role = "Baggage Truck Driver";
    }

    //Method will be called when Tow Truck is clicked on
    public void towTruckScene()
    {
        role = "Tow Truck Driver";
    }

    //Method will be called when Catering Truck is clicked on
    public void cateringTruckScene()
    {
        role = "Catering Truck Driver";
    }
}
