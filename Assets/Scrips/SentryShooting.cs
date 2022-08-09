using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentryShooting : MonoBehaviour
{
    public GameObject player;
    public GameObject pitch;

    public float speed = 10;
    public GameObject shootplace;
    public GameObject bullets;
    public Slider HP;
    public float distance;
    private void Start()
    {
        InvokeRepeating("ShootingPlayer", 2, 1);
    }

    private void Update()
    {
        if(HP.value>0 && Vector3.Distance(transform.position, player.transform.position) < distance)
        {
            Vector3 direction = player.transform.position - transform.position;
            direction = new Vector3(direction.x, 0, direction.z);
            transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, -90, 0);
            pitch.transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position);
        }
    }
    void ShootingPlayer()
    {
        if(HP.value>0&& Vector3.Distance(transform.position, player.transform.position)<distance)
        {
            Instantiate(bullets, shootplace.transform.position, transform.rotation);
        }
    }
}
