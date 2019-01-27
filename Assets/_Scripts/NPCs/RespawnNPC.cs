using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnNPC : MonoBehaviour
{
    
    public GameObject spawnPoint; // Sets where to move our NPC.
    
    private dialogHolder dHolder;
   
    
    // Start is called before the first frame update
    void Start()
    {
        dHolder = FindObjectOfType<dialogHolder>();
    }


    public void MoveNPC()
    {
        // Checks to see if dialogue is currently finished before running.
        if (dHolder.dialogueFinished == true)
        {
            // Sets the location of the triggering NPC from the collision box to whatever spawn point we feed in
            dHolder.triggeringNpc.transform.position = spawnPoint.transform.position; 
            
            dHolder.dialogueFinished = false; // Resets the dialogue finished bool.
        }
    }
    
    

    
}
