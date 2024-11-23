using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWSAD : MonoBehaviour
{
    //Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public float turbo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        turbo = Input.GetAxis("Turbo1");

        //We' ll move the vehicle forward and backwards
        transform.Translate((Vector3.forward * Time.deltaTime * speed * forwardInput)+ (Vector3.forward * Time.deltaTime * speed * forwardInput * turbo));
        //Moving left and right
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * turnSpeed * horizontalInput);
    }
}
