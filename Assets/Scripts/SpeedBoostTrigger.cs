using UnityEngine;

public class SpeedBoostTrigger : MonoBehaviour {

    public float speedBoostForce = 20f;
    public float maxSpeed = 5f;

    public void OnTriggerStay(Collider other) {
        if (other.GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
            ApplySpeedBoost(other);
    }

    private void ApplySpeedBoost(Collider other) => 
        other.GetComponent<Rigidbody>().AddForce(other.GetComponent<Rigidbody>().velocity.normalized * speedBoostForce, ForceMode.Acceleration);
}
