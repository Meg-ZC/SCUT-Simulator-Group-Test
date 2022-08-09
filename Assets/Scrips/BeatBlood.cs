using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatBlood : MonoBehaviour
{

    public Slider HP;
    private void Start()
    {
        HP.value = 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger") && HP.value > 0)
        {
            if (gameObject.CompareTag("Sentry"))
            {
                HP.value -= 1;
            }
            else if (gameObject.CompareTag("Player"))
            {
                HP.value -= 0.01f;
            }
        }
    }
}
