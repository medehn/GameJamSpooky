using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System.Collections;
using Debug = UnityEngine.Debug;

public class Menu : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;

    }

    //to prevent flickering of menu, to react only first key
    private bool keyWasPressed = false;

    void Update()
    {
        
        //show/hide menu
        if (Input.GetAxisRaw("Menu") > 0f)
        {
            Time.timeScale = 0;
            
            if (!keyWasPressed)
            {
                GetComponent<Canvas>().enabled = !GetComponent<Canvas>().enabled;
            }

            keyWasPressed = true;
        }
        else
        {
            keyWasPressed = false;
        }
    }

    //start Game with button, no savegame yet so just disabling the menu
    public void OnButtonStartPressed()
    {
        
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    //quitting game
    public void OnButtonQuitPressed()
    {
        Debug.Log("quitting...");
        Application.Quit();
        
    }
}