using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingBehavior : MonoBehaviour
{
    public float speed = 10;//-100.0f;
    public GameObject shootplace;
    public GameObject bullets;
    void Start()
    {
        InvokeRepeating("ShootingPlayer", 3, 6);
    }

    //InvokeRepeating("SendInfo", 3 , 6); 
    void ShootingPlayer()
    {
        Instantiate(bullets, shootplace.transform.position, transform.rotation);
    }
}
