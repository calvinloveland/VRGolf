using System.Collections;
using UnityEngine;

public class SpeedBoostTrigger : MonoBehaviour {

    public float speedBoostForce = 12f;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Object entered the trigger");
    }

    void OnTriggerStay(Collider other) {
        other.GetComponent<Rigidbody>().AddForce(Vector3.forward * speedBoostForce, ForceMode.Acceleration);
        Debug.Log("Object is within trigger");
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Object exited the trigger");
    }
}
