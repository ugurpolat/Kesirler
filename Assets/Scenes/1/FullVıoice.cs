using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullVıoice : MonoBehaviour
{
    public AudioSource correct, wrong;
    private void OnTriggerEnter2D(Collider2D fruit)
    {
        if (fruit.gameObject.tag == "T1")
        {

            correct.Play();

        }
        else if (fruit.gameObject.tag == "T2")
        {

            correct.Play();
        }
       else if (fruit.gameObject.tag == "T3")
        {

            correct.Play();
        }
       else if (fruit.gameObject.tag == "T4")
        {
            correct.Play();

        }
        else
        {
            wrong.Play();
        }

    }
}
