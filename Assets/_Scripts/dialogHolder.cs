using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMAn;
    public GameObject triggeringNpc;

    public string[] dialogueLines;

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
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //dMAn.ShowBox(dialogue);

                if(!dMAn.dialogActive)
                {
                    dMAn.dialogLines = dialogueLines;
                    dMAn.currentLine = 0;
                    dMAn.ShowDialogue();
                    Destroy(triggeringNpc);
                }
            }
        }
	}
}
