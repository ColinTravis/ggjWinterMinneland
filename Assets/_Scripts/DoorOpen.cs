using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour

{
        
    private Animation doorAnim;

    public GameObject doorToOpen;
    
    private GameObject doorPivot;
    
    public bool doorIsOpen;
    
    // Start is called before the first frame update
    void Start()
    {

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
                if(!doorIsOpen)
                {
                    print("Open the door");
                    doorToOpen.GetComponent<Animation>().Play("doorOpen");
                    doorIsOpen = true;
                }
            }
        }
    }
    
    

}
