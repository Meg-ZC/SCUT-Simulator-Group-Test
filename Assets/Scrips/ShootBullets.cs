using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootBullets : MonoBehaviour
{
    public float speed = 10;//-100.0f;
    private Rigidbody bullets;
    private Camera shootCamera;
    void Start()
    {
        shootCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        bullets = GetComponent<Rigidbody>();
        bullets.AddForce(shootCamera.transform.forward * speed, ForceMode.Impulse);
    }
    private void Update()
    {
        if (transform.position.y < -10)
            Destroy(gameObject);
    }
}
