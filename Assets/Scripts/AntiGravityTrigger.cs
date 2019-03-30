using System.Collections;
using UnityEngine;

public class AntiGravityTrigger : MonoBehaviour {

    public float hoverForce = 12f;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Object entered the trigger");
    }

    void OnTriggerStay(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
        Debug.Log("Object is within trigger");
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Object exited the trigger");
    }
}
