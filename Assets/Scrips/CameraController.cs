using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private float xRotation;
    private float yRotation;

    public float mouseSensity = 1000;

    public GameObject bullets;
    private GameObject heroCar;
    private GameObject shootPlace;

    public Camera[] Camera;
    public Slider[] HP;

    private bool bSwitchCamera = true;

    void Start()
    {
        heroCar = GameObject.Find("Standard");
        shootPlace = GameObject.Find("ShootPlace");
    }

    void Update()
    {
        xRotation = Input.GetAxis("Mouse X") * mouseSensity * Time.deltaTime;
        yRotation = Input.GetAxis("Mouse Y") * mouseSensity * Time.deltaTime;

        transform.Rotate(Vector3.right * yRotation);
        heroCar.transform.Rotate(Vector3.up * xRotation);
        
        if(HP[0].value > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bullets, shootPlace.transform.position, transform.rotation);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                SwitchCamera();
                bSwitchCamera = !bSwitchCamera;
            }
        }


        HP[1].value = HP[0].value;

    }
    void SwitchCamera()
    {
        Camera[0].gameObject.SetActive(!bSwitchCamera);
        Camera[1].gameObject.SetActive(bSwitchCamera);
        HP[0].gameObject.SetActive(!bSwitchCamera);
    }
}
