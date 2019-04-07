using UnityEngine;

public class BallPhysics : MonoBehaviour {

    public GameObject playerCamera;
    public float stoppingThreshold;
    public float timeUntilStopping;
    public bool stop;

    private float timer = 0.0f;
    private Vector3 offset;
    private Vector3 lastPosition;

    void Start() {
        stoppingThreshold = GetComponent<BallPhysics>().stoppingThreshold;
        offset = playerCamera.transform.position - transform.position;
        lastPosition = transform.position;
    }

    void Update() {
        timer += Time.deltaTime;
        if (stop && timer > timeUntilStopping) {
            if (GetComponent<Rigidbody>().velocity.magnitude <= stoppingThreshold) {
                GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                playerCamera.transform.position = transform.position + offset;
                timer = 0.0f;
                lastPosition = transform.position;
            }
        }
    }

    public void Reset() {
        transform.position = lastPosition;
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);

        //In case of emergency uncomment line
        //playerCamera.transform.position = transform.position + offset;
    }
}
