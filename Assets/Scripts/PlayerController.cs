using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    //
    public float horizontalInput;
    public float multHorizontalInput;
    //
    public float forwardInput;
    public float MultForwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //code that will move vehicles forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*(forwardInput*MultForwardInput));
        transform.Rotate(Vector3.up, turnSpeed*Time.deltaTime*horizontalInput);
    }
    //-1.08
    //-2.231382
    //5.142273
}
