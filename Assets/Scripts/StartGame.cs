﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	
	
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            Game.instance.LoadNextLevel();
        }
	}
}
