using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dBox;
    public Text dText;

    private dialogHolder dHolder;
    
    private RespawnNPC spwnNPC;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dHolder = FindObjectOfType<dialogHolder>();
        spwnNPC = FindObjectOfType<RespawnNPC>();
    }

    void Update()
    {
        if(dialogActive && Input.GetKeyUp(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button16))
    {
        // Advance through dialogue array
            currentLine++;
    }
        if(currentLine >= dialogLines.Length)
        {
            // Reset dialogue after lines are exhausted
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;

            // Tells us the dialogue is finished, rather than just reset.
            dHolder.dialogueFinished = true;
            spwnNPC.MoveNPC();
        }

        dText.text = dialogLines[currentLine];
    
    }

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }


}
