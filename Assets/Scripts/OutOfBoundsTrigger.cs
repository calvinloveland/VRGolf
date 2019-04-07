using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsTrigger : MonoBehaviour
{
    void OnTriggerExit(Collider other) {
        BallPhysics bp = other.GetComponent<BallPhysics>();
        if (bp) {
            bp.Reset();
        }
    }
}
