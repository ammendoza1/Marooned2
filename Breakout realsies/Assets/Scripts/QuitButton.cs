using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    // the main menu
    public void ButtonMOveScene(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }

}
