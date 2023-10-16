using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject throwerParent;
    public GameObject destination;
    public Vector3 startingPos;
    public Vector3 destinationFinal;
    public float flameSpeedFromParent;

    private float journeyLength;
    private float startTime;

    private void Start()
    {
        throwerParent = transform.parent.gameObject;
        startingPos = throwerParent.transform.position;
        flameSpeedFromParent = throwerParent.GetComponent<Flamethrower>().flameSpeed;
        destination = throwerParent.GetComponent<Flamethrower>().flameDestination;
        destinationFinal = new Vector3(destination.transform.position.x, destination.transform.position.y, destination.transform.position.z);

        StartInterpolation();
    }

    public void StartInterpolation()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startingPos, destinationFinal);
        StartCoroutine(InterpolatePosition());
    }

    private IEnumerator InterpolatePosition()
    {
        while (transform.position != destinationFinal)
        {
            float distanceCovered = (Time.time - startTime) * flameSpeedFromParent;
            float journeyFraction = distanceCovered / journeyLength;
            transform.position = Vector3.Lerp(startingPos, destinationFinal, journeyFraction);
            yield return null;
        }
        Destroy(gameObject);
    }
}