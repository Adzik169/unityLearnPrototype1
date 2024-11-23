using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam2 : MonoBehaviour
{
    public GameObject player3;
    private Vector3 offset = new Vector3(0, 2.25f, -0.12f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player3.transform.position + offset;
        transform.rotation = player3.transform.rotation;
    }
}
