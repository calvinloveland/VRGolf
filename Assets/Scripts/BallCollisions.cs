using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisions : MonoBehaviour
{
    public GameObject club;
    public TextMesh score;
    private int strokes;
    public float multiplier = 50;
    private static float cooldown = 1;
    private static float lastHit = 0;

    public void OnCollisionEnter(Collision collision) {
        if ((collision.transform.parent.gameObject == club) && Time.time - lastHit > cooldown)
        {
            strokes++;
            score.text = strokes.ToString();
            lastHit = Time.time;
            Debug.Log(collision.gameObject.GetComponent<GolfClub>().velocity);
            gameObject.GetComponent<Rigidbody>().AddForce(collision.gameObject.GetComponent<GolfClub>().velocity * multiplier);
        }
        else {
            Debug.Log("No HIT");
        }
    }
}
