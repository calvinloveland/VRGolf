using System.Collections;
using UnityEngine;

public class SpeedBoostTrigger : MonoBehaviour {

    public float speedBoostForce = 9.807f;

    void OnTriggerEnter(Collider other) => Debug.Log(message: $"{other.name} entered the trigger");

    void OnTriggerStay(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.forward * speedBoostForce, ForceMode.Acceleration);
        Debug.Log(message: $"{other.name} is within the trigger");
    }

    void OnTriggerExit(Collider other) => Debug.Log(message: $"{other.name} exited the trigger");
}
