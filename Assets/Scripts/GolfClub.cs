using UnityEngine;

public class GolfClub : MonoBehaviour {

    public Vector3 velocity;
    private Vector3 lastPosistion;

    public void Start() {
        lastPosistion = transform.position;
    }

    public void FixedUpdate() {
        velocity = (transform.position - lastPosistion) * (1/Time.fixedDeltaTime);
        lastPosistion = transform.position;
    }

}
