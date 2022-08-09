using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHP : MonoBehaviour
{
    public Slider sentryHp;
    public Slider baseHp;
    private PlayerController playercontroller;

    private void Start()
    {
        playercontroller = GameObject.Find("Standard").GetComponent<PlayerController>();
        baseHp.value = 1;
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(sentryHp.value == 0&&collision.gameObject.CompareTag("ScoreTrigger"))
        {
            baseHp.value -= 1;
            playercontroller.GameOver();
        }
    }
}
