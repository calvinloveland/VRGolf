using UnityEngine;

public class Rotator : MonoBehaviour {

    public float rotationsPerMinute;

    public void Update() {
        transform.rotation *= Quaternion.Euler(0, rotationsPerMinute * Time.deltaTime, 0);

    }
}
