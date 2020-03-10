using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick movementJoystick;

    [SerializeField]
    float playerSpeed;

    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = movementJoystick.Horizontal * playerSpeed;
        float verticalMovement = movementJoystick.Vertical * playerSpeed;
    }
}
