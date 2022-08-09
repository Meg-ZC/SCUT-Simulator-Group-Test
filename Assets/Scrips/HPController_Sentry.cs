using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HPController_Sentry : MonoBehaviour
{
    public GameObject[] cameras;
    private int index = 0;


    void Update()
    {
        transform.LookAt(cameras[index].transform.position);
        if(Input.GetKeyDown(KeyCode.X))
        {
            switch (index)
            {
                case 0:
                    index = 1;
                    break;
                case 1:
                    index = 0;
                    break;
                default:
                    break;
            }
        }
    }


}
