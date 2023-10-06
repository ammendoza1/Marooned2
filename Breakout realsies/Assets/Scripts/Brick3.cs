using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick3 : MonoBehaviour
{
    public float speed = 3;
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void decreaseSpeed()
    {
        speed--;
    }
}
