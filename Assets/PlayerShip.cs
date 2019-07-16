using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public GameObject mainCamera;
    public KeyCode forward;
    public KeyCode backward;

    private ShipTable ship;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ship = GetComponent<ShipTable>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(forward))
        {
            rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity + rigidBody.transform.forward * ship.forwardAcceleration, 15);
        }
        else
        {
            rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity + rigidBody.transform.forward * ship.forwardDeceleration, 0);
        }
    }
}
