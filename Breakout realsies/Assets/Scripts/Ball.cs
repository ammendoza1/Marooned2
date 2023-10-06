using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// the ball moving and stuff
public class Ball : MonoBehaviour
{

    private Vector3 startPosition;
    Vector3 moveVector3 = Vector3.down;

    Bricks brick;

    public Transform target;
    private Rigidbody rigidBody;

    public int lives = 3;
    public int score = 0;

    public float stunTimer;
    public float speed = 5;

    public Text livesText;
    public Text scoreText;
    public Text gameOverText; 

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveVector3);
        if(lives <= 0)
        {
            this.enabled = false;
        }
        rigidBody = GetComponent<Rigidbody>();
    }

    //moving the ball up and down
    private void Move(Vector3 moveDirection)
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    //player respawns and like does a stuttering thing
    private void Respawn()
    {
        transform.position = startPosition;
        if(lives <= 0)
        {
            this.enabled = false;
        }
        StartCoroutine(Stutter());
    }

    //that blinking we learned in 180?

    public IEnumerator Stutter()
    {
        for(int index = 0; index < 20; index++)
        {
            if(index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(0.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }

    //on trigger enter functions
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball smashed with:" + collision.collider.name);
        // respawning ball
        if(collision.transform.parent.tag == "brick_01")
        {
            // brick 1 collision
        }
        //brick 02 collision


        //decreased speed
        //make void that decreases speed


        // increase speed
        //make void that increases
        
    }

    // if ball hit wall -- bounce



}
