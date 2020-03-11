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
        float horizontalMovement = movementJoystick.Horizontal * playerSpeed;
        float verticalMovement = movementJoystick.Vertical * playerSpeed;

        Movimiento(horizontalMovement, verticalMovement);
    }

    void Movimiento(float hMove, float vMove)
    {
        movement.Set(hMove, 0, vMove);
        movement = movement.normalized * playerSpeed * Time.deltaTime;
        rigidBody.MovePosition(transform.position + movement);
    }
}
