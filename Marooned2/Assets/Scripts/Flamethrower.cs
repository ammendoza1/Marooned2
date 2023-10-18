using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : MonoBehaviour
{   
    [Header("=== PRIMARY VARIABLES ===")]
    public bool grippy = false;
    public bool isOn = false;

    [Header("=== MAIN VARIABLES ===")]
    public GameObject flamePrefab;
    public GameObject flameDestination;
    public int flameTimer = 200;
    private int flameTime;
    public float flameSpeed = 1.0f;

    private void Start()
    {
        flameTime = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FlameCheck();
    }

    public void FlameCheck()
    {
        if (isOn && flameTime >= flameTimer)
        {
            flameTime = 0;
            Instantiate(flamePrefab, transform);
        }
        else
        {
            flameTime++;
        }
        return;
    }
    
}
