using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTDOrion : ShipTable
{


    // Start is called before the first frame update
    void Start()
    {
        shipName = "GTD Orion";

        maxVelocity = 15;

        species = "Terran"; // maybe change to enum

        rotationTime = new Triplet(150, 150, 150);

        forwardAcceleration = 20;

        forwardDeceleration = 10;

        hitpoints = 2000000;

        shieldHitpoints = 2000000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
