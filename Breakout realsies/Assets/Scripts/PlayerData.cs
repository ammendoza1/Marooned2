using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    // UI for game over, paddle, etc.
    public Text scoreText;
    public int score = 0;

    private void Start()
    {
        scoreText.text = "Score:" + score.ToString();
    }


}
