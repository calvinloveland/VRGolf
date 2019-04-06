using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HoleTrigger : MonoBehaviour
{
    public GameObject Ball;
    public string NextScene; 
    void OnTriggerEnter(Collider other) {
        if (other.gameObject == Ball) {
            Debug.Log("GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOal");
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
    }
}
