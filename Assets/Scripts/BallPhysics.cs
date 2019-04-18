using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallPhysics : MonoBehaviour {

    public GameObject playerCamera;
    public float stoppingThreshold;
    public float timeToStopBallSeconds;
    public float slowdown = 1.1f;

    private float timeUntilStopping = 0.0f;
    private Vector3 cameraOffset;
    private Vector3 lastBallPosition;

    void Start() {
        cameraOffset = playerCamera.transform.position - transform.position;
        lastBallPosition = transform.position;
    }

    void Update() {
        if (SteamVR_Actions._default.Teleport.GetState(SteamVR_Input_Sources.Any))
            playerCamera.transform.position = transform.position + cameraOffset;

        timeUntilStopping += Time.deltaTime;

        if (timeUntilStopping > timeToStopBallSeconds) {
            if (GetComponent<Rigidbody>().velocity.magnitude <= stoppingThreshold)
                StopObject();
            else {
                GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity / slowdown;
                GetComponent<Rigidbody>().angularVelocity = GetComponent<Rigidbody>().angularVelocity / slowdown;
            }
        }
    }

    public void Reset() {
        transform.position = lastBallPosition;
        StopObject();
    }

    private void StopObject() {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);

        timeUntilStopping = 0.0f;

        // playerCamera.transform.position = transform.position + cameraOffset;

        lastBallPosition = transform.position;
    }
}
