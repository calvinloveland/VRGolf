using UnityEngine;

public class SpeedBoostTrigger : MonoBehaviour {

    public float speedBoostForce = 20f;
    public float maxSpeed = 5f;

    void OnTriggerEnter(Collider other) => Debug.Log(message: $"{other.name} entered the trigger");

    void OnTriggerStay(Collider other) {
        if (other.GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
        {
            Debug.Log(message: $"{other.name} is within the trigger");
            other.GetComponent<Rigidbody>().AddForce(other.GetComponent<Rigidbody>().velocity.normalized * speedBoostForce, ForceMode.Acceleration);
        }
        
    }

    void OnTriggerExit(Collider other) => Debug.Log(message: $"{other.name} exited the trigger");
}
