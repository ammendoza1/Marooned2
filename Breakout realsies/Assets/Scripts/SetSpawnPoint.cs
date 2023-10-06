using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("ball").transform.position = gameObject.transform.position;
    }

     
    
}
