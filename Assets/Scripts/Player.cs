using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick movementJoystick;

    [SerializeField]
    float playerSpeed;

    Rigidbody rigidBody;

    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement.x = gameObject.transform.position.x + movementJoystick.Horizontal;
        movement.z = gameObject.transform.position.z + movementJoystick.Vertical;
        rigidBody.AddForce(movement * playerSpeed);
    }
}
