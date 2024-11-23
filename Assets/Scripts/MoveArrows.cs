using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrows : MonoBehaviour
{
    //Private Variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float xInput;
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
        xInput = Input.GetAxis("Player2X");
        forwardInput = Input.GetAxis("Player2Y");
        turbo = Input.GetAxis("Turbo2");

        //We' ll move the vehicle forward and backwards
        transform.Translate((Vector3.forward * Time.deltaTime * speed * forwardInput)+(Vector3.forward * Time.deltaTime * speed * forwardInput * -turbo));
        //Moving left and right
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * turnSpeed * xInput);
    }
}
