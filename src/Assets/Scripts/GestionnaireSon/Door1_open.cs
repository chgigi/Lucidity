﻿using UnityEngine;
using System.Collections;

public class Door1_open : MonoBehaviour {

    public Porte door;
    public bool msg;
	// Use this for initialization
	void Start () {
        msg = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
            if (!door.open)
            {
                msg = true;
                GameObject.Find("TextInter").SendMessage("addText", "Tu vas devoir traverser un labyrinthe , ton objectif , trouver la sortie !");
            }
            else if (msg)
            {
                msg = false;
                GameObject.Find("TextInter").SendMessage("removeText");
            }
        }
    }

