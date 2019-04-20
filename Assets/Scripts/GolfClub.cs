using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Valve.VR;

public class GolfClub : MonoBehaviour {

    public Vector3 velocity;
    private Vector3 lastPosistion;


    public string NextScene;

    private float sceneChangeTimer = 3f;
    private float timer = 3f;


    public void Start() {
        lastPosistion = transform.position;
    }

    public void FixedUpdate() {
        CheckTriger();
        CheckTrackpad();
        CheckGrip();

        VelocityUpdate();
    }

    private void CheckTriger()
    {
        // If triger is pulled, enable collision with golfball
        if (SteamVR_Actions._default.GrabPinch.GetState(SteamVR_Input_Sources.Any))
            GetComponent<Collider>().enabled = true;
        else
            GetComponent<Collider>().enabled = false;

    }

    private void CheckTrackpad()
    {
        // If trackpad is pressed, disable collison with golfball
        if (SteamVR_Actions._default.Teleport.GetState(SteamVR_Input_Sources.Any))
        {
            GetComponent<Collider>().enabled = false;
            Debug.Log("trackpad pressed");
        }
    }

    private void CheckGrip()
    {
        //If grip is squeezed, count down timer then invoke next scene
        if (SteamVR_Actions._default.GrabGrip.GetState(SteamVR_Input_Sources.Any))
        {
            Debug.Log(timer);
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Debug.Log("Invoke Scene Change");
                SceneTransition();
            }
        }
        else
        {
            timer = sceneChangeTimer;
        }
    }

    private void VelocityUpdate()
    {
        velocity = (transform.position - lastPosistion) * (1 / Time.fixedDeltaTime);
        lastPosistion = transform.position;
    }

    private void SceneTransition()
    {
        SteamVR_LoadLevel.Begin(NextScene);
        //SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }
}
