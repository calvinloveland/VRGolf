using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GolfClub : MonoBehaviour {

    public Vector3 velocity;
    private Vector3 lastPosistion;

    public void Start() {
        lastPosistion = transform.position;
    }

    public void FixedUpdate() {
        if (SteamVR_Actions._default.GrabPinch.GetStateUp(SteamVR_Input_Sources.Any))
            GetComponent<Collider>().enabled = false;
        if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
            GetComponent<Collider>().enabled = true;
        if (SteamVR_Actions._default.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
            GetComponent<Collider>().enabled = false;


        velocity = (transform.position - lastPosistion) * (1 / Time.fixedDeltaTime);
        lastPosistion = transform.position;
    }

}
