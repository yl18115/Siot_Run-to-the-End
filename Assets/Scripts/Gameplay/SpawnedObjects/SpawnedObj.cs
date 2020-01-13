﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnedObj : MonoBehaviour {
    // ======================================================================
    // MonoBehaviour Methods
    // ======================================================================

    // --------------- Fields to be attached Component Instances ---------------

    protected PlayerStatus _playerStatus;

    // ======================================================================
    // MonoBehaviour Methods
    // ======================================================================

    void Start() {
        _playerStatus = FindObjectOfType<PlayerStatus>();
    }

    protected virtual void Update() {
        DestroySelf();
    }

    protected abstract void OnTriggerEnter2D(Collider2D coll);

    // ======================================================================
    // Customised Methods
    // ======================================================================

    // when the obstacle is 1.5 screen width behind the player, destroy itself
    protected virtual void DestroySelf() {
        float xPosSelf   = gameObject.transform.position.x;
        float xPosPlayer = PlayerControl.PlayerTransform.position.x;

        // calculate the x distance between position of obstacle itself and the player
        if (xPosSelf - xPosPlayer < 3 * ScreenUtils.ScreenLeft) {
            Destroy(gameObject);
        }
    }
}