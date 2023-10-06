using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick2 : MonoBehaviour
{
    public float speed = 4;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void increase Speed()
    {
        speed++;
    }
}
