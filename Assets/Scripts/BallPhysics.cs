using UnityEngine;

public class BallPhysics : MonoBehaviour {

    public GameObject playerCamera;
    public float stoppingThreshold;
    public float timeUntilStopping;

    private float timer = 0.0f;
    private Vector3 offset;

    void Start() {
        stoppingThreshold = GetComponent<BallPhysics>().stoppingThreshold;
        offset = playerCamera.transform.position - transform.position;
    }

    void Update() {
        timer += Time.deltaTime;
        if (timer > timeUntilStopping) {
            if (GetComponent<Rigidbody>().velocity.magnitude <= stoppingThreshold) {
                //GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
                //GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                playerCamera.transform.position = transform.position + offset;
                timer = 0.0f;
            }
        }
    }
}
