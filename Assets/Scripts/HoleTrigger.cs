using UnityEngine;
using UnityEngine.SceneManagement;


public class HoleTrigger : MonoBehaviour {

    public GameObject Ball;
    public ParticleSystem Fireworks;
    public float SceneTransitionTime = 10f;
    public string NextScene;

    public void OnTriggerEnter(Collider other) { 
        if (other.gameObject == Ball) {
            Fireworks.Play();
            Invoke("SceneTransition", SceneTransitionTime);
        }
    }

    private void SceneTransition() => SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
}
