using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hakf : MonoBehaviour
{
    public AudioSource correct, wrong;
    private void OnTriggerEnter2D(Collider2D fruit)
    {
        if (fruit.gameObject.tag == "Y1")
        {
            correct.Play();
        }
        else if (fruit.gameObject.tag == "Y2")
        {
            correct.Play();
        }
        else
        {
            wrong.Play();
        }


    }
}
