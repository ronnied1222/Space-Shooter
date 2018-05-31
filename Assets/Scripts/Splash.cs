﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadNextLevel", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadNextLevel(){
        SceneManager.LoadScene(1);
    }
}
