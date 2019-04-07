using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float distance;
    public float period;
    private float start;
    private bool goingUp;
    // Start is called before the first frame update
    void Start()
    {
        goingUp = false;
        start = transform.position.y;
    }

    void FixedUpdate()
    {
        float movement = distance / period;
        if (goingUp)
            movement *= -1;
        if (transform.position.y > start)
            goingUp = false;
        if (transform.position.y < start + distance)
            goingUp = true;
        transform.Translate(Vector3.forward * movement);
    }
}
