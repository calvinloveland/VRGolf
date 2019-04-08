using UnityEngine;

public class BallPhysics : MonoBehaviour {

    public GameObject playerCamera;
    public float stoppingThreshold;
    public float timeToStopBallSeconds;

    private float timeUntilStopping = 0.0f;
    private Vector3 cameraOffset;
    private Vector3 lastBallPosition;

    void Start() {
        cameraOffset = playerCamera.transform.position - transform.position;
        lastBallPosition = transform.position;
    }

    void Update() {
        timeUntilStopping += Time.deltaTime;

        if (timeUntilStopping > timeToStopBallSeconds)
            if (GetComponent<Rigidbody>().velocity.magnitude <= stoppingThreshold)
                StopObject();
    }

    public void Reset() {
        transform.position = lastBallPosition;
        StopObject();
    }

    private void StopObject() {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);

        timeUntilStopping = 0.0f;
        playerCamera.transform.position = transform.position + cameraOffset;

        lastBallPosition = transform.position;
    }
}
