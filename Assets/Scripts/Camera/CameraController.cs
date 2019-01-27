using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject followTarget;

    private Vector3 targetPos;
    public float cameraDrag;

//    public Vector3 offset;
    public float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPos = new Vector3(followTarget.transform.position.x, transform.position.y, followTarget.transform.position.z + zOffset);
        transform.position = Vector3.Lerp( transform.position, targetPos, cameraDrag * Time.deltaTime );
    }
}





