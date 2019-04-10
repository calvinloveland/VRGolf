using UnityEngine;

public class GolfClub : MonoBehaviour {

    public GameObject golfBall;
    public float sensitivity = 100f;

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject != golfBall) return;

        ;
        other.GetComponent<Rigidbody>().AddForce((Vector3.one + other.GetComponent<Rigidbody>().velocity.normalized) * sensitivity, ForceMode.Acceleration);
    }
}
