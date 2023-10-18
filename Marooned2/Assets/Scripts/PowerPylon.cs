using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pylon : MonoBehaviour
{
    [Header("=== PRIMARY VARIABLES ===")]
    public bool grippy = false;
    public bool isOn = false;

    [Header("=== MAIN VARIABLES ===")]
    public GameObject reach;
    public GameObject electricity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        electricity.SetActive(isOn);
    }

}
