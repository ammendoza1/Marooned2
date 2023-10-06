using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
  // changes scene based on button game thingy
  public void ButtonMoveScene(string Lvl_1)
    {
        SceneManager.LoadScene(Lvl_1);
    }
}
