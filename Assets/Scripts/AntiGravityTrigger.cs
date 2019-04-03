using System.Collections;
using UnityEngine;

public class AntiGravityTrigger : MonoBehaviour {

    public float hoverForce = 9.807f;

    void OnTriggerEnter(Collider other) => Debug.Log(message: $"{other.name} entered the trigger");

    void OnTriggerStay(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
        Debug.Log(message: $"{other.name} is within the trigger");
    }

    void OnTriggerExit(Collider other) => Debug.Log(message: $"{other.name} exited the trigger");
}
