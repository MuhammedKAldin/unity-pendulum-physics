using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField]
    public Pendulum pendulum;

    // Start is called before the first frame update
    void Start()
    {
        pendulum.Initalise();
    }

    // FixedUpdate for the Physics based movement
    void FixedUpdate()
    {
        // Time.fixedDeltaTime doesn’t care about the interval between frames and will always give you the Fixed Timestep value
        transform.localPosition = pendulum.MoveBob(transform.localPosition, Time.fixedDeltaTime);

    }
}
