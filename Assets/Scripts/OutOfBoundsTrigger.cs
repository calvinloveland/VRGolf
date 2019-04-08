using UnityEngine;

public class OutOfBoundsTrigger : MonoBehaviour {

    public void OnTriggerExit(Collider other) {
        BallPhysics ballPhysics = other.GetComponent<BallPhysics>();
        if (ballPhysics) ballPhysics.Reset();
    }
}
