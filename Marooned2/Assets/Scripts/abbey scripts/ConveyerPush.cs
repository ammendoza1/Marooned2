using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerPush : MonoBehaviour
{
    public float speed;
    Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += Vector3.back * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }
}
