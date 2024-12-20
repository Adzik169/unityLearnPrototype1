using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public GameObject ThirdCam;
    public GameObject FirstCam;
    public int CamMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Camera2"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }
            else { 
                CamMode = 1;
            }
            StartCoroutine(CameraChange());
        }
    }
    IEnumerator CameraChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            ThirdCam.SetActive(false);
            FirstCam.SetActive(true);
        }

    }
}
