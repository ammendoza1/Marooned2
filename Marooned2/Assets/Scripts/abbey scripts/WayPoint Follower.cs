using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abbey code
// generic waypoints for enemies/platforms to move in between.
//pretty sure you just add the waypoints with the script and it works



public class WayPointFollower : MonoBehaviour
{

    [SerializeField] GameObject[] wayPoints;
    int currentWayPointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {

        //checking waypoint to move to
        if(Vector3.Distance(transform.position, wayPoints[currentWayPointIndex].transform.position) < .1f)
        {
            currentWayPointIndex++;
            // can also write it this way
            //currentWayPointIndex = currentWayPointIndex + 1;
            if(currentWayPointIndex >= wayPoints.Length)
            {
                currentWayPointIndex = 0;
        
            }
        }

        //making it move  
        //making it move  
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
