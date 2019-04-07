using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HoleTrigger : MonoBehaviour
{
    public GameObject Ball;
    public ParticleSystem Fireworks;
    public float SceneTransitionTime = 10f;

    public string NextScene;

    void OnTriggerEnter(Collider other) { 
        if (other.gameObject == Ball) {
            Fireworks.Play();
            Invoke("SceneTransition", SceneTransitionTime);
        }
    }

    private void SceneTransition() {
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }
}
