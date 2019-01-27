using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMAn;

    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                dMAn.ShowBox(dialogue);
            }
        }
	}
}
