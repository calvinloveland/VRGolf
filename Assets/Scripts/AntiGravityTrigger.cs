using UnityEngine;

public class AntiGravityTrigger : MonoBehaviour {

    public float hoverForce = 9.807f;

    public void OnTriggerStay(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
