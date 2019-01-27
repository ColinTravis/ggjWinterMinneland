using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dBox;
    public Text dText;

    private dialogHolder dHolder;

    public bool dialogActive;

    public string[] dialogLines;
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dHolder = FindObjectOfType<dialogHolder>();
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
            dHolder.dialogueFinished = true;
            dHolder.DestroyNPC();

        }

        dText.text = dialogLines[currentLine];
    
    }

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
    }


}
