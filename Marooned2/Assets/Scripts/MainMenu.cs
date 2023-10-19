using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// this is the main menu script.
// it will be for the play and quit buttons so they work.

public class MainMenu : MonoBehaviour
{

    // this is supposed to be the play button
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    //this is the quit button 
    public void QuitGame()
    {
        //Debug is to see that it is working in unity  bc
        //it wont actually quit in Unity but it will in game/build
        Debug.Log("QUIT!");
        Application.Quit();
    }





}
