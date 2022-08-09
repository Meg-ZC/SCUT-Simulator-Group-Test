using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float forwardWS;
    public float rotateAD;
    public Slider HP;
    public GameObject[] button;

    private void Start()
    {
        button[0].gameObject.SetActive(false);
        button[1].gameObject.SetActive(false);

    }
    void Update()
    {
        if(HP.value>0)
        {
            forwardWS = -Input.GetAxis("Vertical");
            rotateAD = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardWS);
            transform.Translate(Vector3.left * speed * Time.deltaTime * rotateAD);
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        button[0].SetActive(true);
        button[1].SetActive(true);
    }
}
