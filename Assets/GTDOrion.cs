using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTDOrion : ShipTable
{
    public string shipName = "GTD Orion";

    public float maxVelocity = 15;

    public string species = "Terran"; // maybe change to enum

    public float[] rotationTime = {150, 150, 150};

    public float forwardAcceleration = 20;

    public float forwardDeceleration = 10;

    public float hitpoints = 2000000;

    public float shieldHitpoints = 2000000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
