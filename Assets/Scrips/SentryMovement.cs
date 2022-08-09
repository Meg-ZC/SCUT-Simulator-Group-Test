using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentryMovement : MonoBehaviour
{
    public float[] speed;
    public int direction = 1;
    public int randIndex = 1;
    public Slider HP;
    void Update()
    {
        if (HP.value > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed[randIndex] * direction);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

            if (other.CompareTag("Bound"))
            {
                direction *= -1;
                randIndex = Random.Range(0, 4);
            }
    }
}
