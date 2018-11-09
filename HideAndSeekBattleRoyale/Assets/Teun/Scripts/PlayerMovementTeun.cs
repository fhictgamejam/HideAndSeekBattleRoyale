using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerMovementTeun : NetworkBehaviour {
    private PlayerManager playerManager;

    public AudioSource AudioSource;

    //public Camera StartCam;
    public Camera cam;

    public float speed = 10.0f;

    void Start() {
        Destroy(Camera.main);
        if (!isLocalPlayer) {
            cam.enabled = false;
        }

        playerManager = FindObjectOfType<PlayerManager>();
        playerManager.Players.Add(this);
        AudioSource = GetComponent<AudioSource>();
    }

    void Update() {
        if (!isLocalPlayer) {
            return;
        }

        float Xtranslation = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        float Ytranslation = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Xtranslation, 0, Ytranslation);
    }
}