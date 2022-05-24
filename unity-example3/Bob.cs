using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bob 
{

    public Vector3 velocity;
    public float gravity = 20f;
    public Vector3 gravityDirection = new Vector3(0, 1, 0);

    // Simulating air ressistance which dicreases swinging velocity, via hitting player in opposite direction
    Vector3 dampingDirection;
    public float drag; // Maybe a 0.001

    public float maximumSpeed; // Maybe 50

    // Start is called before the first frame update
    public void ApplyGravity()
    {
        velocity -= gravityDirection * gravity * Time.deltaTime;
    }

    // Update is called once per frame
    public void ApplyDamping()
    {
        dampingDirection = -velocity;
        dampingDirection *= drag;
        velocity += dampingDirection;
    }

    public void CapMaxSpeed()
    {
        velocity = Vector3.ClampMagnitude(velocity, maximumSpeed);
    }

}
