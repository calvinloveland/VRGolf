using UnityEngine;

public class Elevator : MonoBehaviour {

    public float offset;
    public float travelTimeSeconds;

    private bool goingDown;
    private float distance;
    private float start;
    private float end;
    
    public void Start() {
        goingDown = false;

        start = transform.position.y;
        end = start + offset;

        // Set the start to be above the end
        if (start < end) {
            var swap = end;
            end = start;
            start = swap;
        }

        distance = start - end;
    }

    public void Update() {
        if (transform.position.y > start) goingDown = true;
        if (transform.position.y < end) goingDown = false;

        float deltaDistance = distance / travelTimeSeconds;
        if (goingDown) deltaDistance *= -1;

        transform.Translate(Vector3.forward * deltaDistance * Time.deltaTime);
    }
}
