using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets_Sentry : MonoBehaviour
{
    public float speed = 10;//-100.0f;
    private Rigidbody bullets;
    private GameObject shootplace;
    void Start()
    {
        shootplace = GameObject.Find("ShootPlace1");
        bullets = GetComponent<Rigidbody>();
        bullets.AddForce(shootplace.transform.forward * speed, ForceMode.Impulse);
    }
    private void Update()
    {
        if (transform.position.y < -10)
            Destroy(gameObject);
    }
}
