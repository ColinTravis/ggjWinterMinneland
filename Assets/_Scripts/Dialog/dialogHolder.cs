using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMAn;
    
    public GameObject triggeringNpc;
    
    public string[] dialogueLines;

    public bool dialogueFinished;

    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
	{
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button16))
            {

                if(!dMAn.dialogActive)
                {
                    dMAn.dialogLines = dialogueLines;
                    dMAn.currentLine = 0;
                    dMAn.ShowDialogue();
                }
            }
        }
	}

    public void DestroyNPC()
    {
        if (dialogueFinished == true)
        {
            Destroy(triggeringNpc);
            
            dialogueFinished = false;
        }
    }
}
