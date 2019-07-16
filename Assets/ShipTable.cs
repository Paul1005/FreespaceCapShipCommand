using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Web.UI;

public class ShipTable : MonoBehaviour
{
    public string shipName;

    public float maxVelocity;

    public string species; // maybe change to enum

    public Triplet rotationTime;

    public float forwardAcceleration;

    public float forwardDeceleration;

    public float hitpoints;

    public float shieldHitpoints;
}
