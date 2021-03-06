﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forPlayer : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;

	void Update()
	{
        if(triggering)
        {

            if(Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button16))
            {
                //This is where we want to put our dialog or destroy npc   
                print("Hey! It's ya boy, Greg!");
                Destroy(triggeringNpc);
                triggering = false;
            }
        }  
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
