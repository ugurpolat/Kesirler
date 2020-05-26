using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quarter : MonoBehaviour
{
    public AudioSource correct, wrong;
    private void OnTriggerEnter2D(Collider2D fruit)
    {


        if (fruit.gameObject.tag == "C1")
        {
            correct.Play();
        }
       else if (fruit.gameObject.tag == "C2")
        {
            correct.Play();
        }
       else if (fruit.gameObject.tag == "C3")
        {
            correct.Play();
        }
        else
        {
            wrong.Play();
        }

    }
}
