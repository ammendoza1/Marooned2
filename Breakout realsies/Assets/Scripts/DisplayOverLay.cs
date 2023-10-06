using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.SceneManagement;

public class DisplayOverLay : MonoBehaviour
{
    public int lives = 3;
    public Text livesText;
    public Text gameOverText;
    public Text scoreText;
    public int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        SetCountText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // counting the lives
    public void SetCountText()
    {
        scoreText.text = "Score:" + score.ToString();

        if(lives <= 0)
        {
            SceneManager.LoadScene();
            gameOverText.text = "Game Over!";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print("trigger?");
        if(other.gameObject.tag == "bricked")
        {
            score++;
            print("broke the brick!SCORE!");
            score = score;
            SetCountText();
        }
        if(other.gameObject.tag == "pit falling no!!")
        {
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            deleteLives();

        }
    }

    public void deleteLives()
    {
        lives--;
        if(lives <= 0)
        {
            this.enabled = false;
        }
        SetCountText();
    }



}
