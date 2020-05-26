using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCheckQuarter : MonoBehaviour
{
    bool a, b,c;
    public bool check3 = false;
    // Update is called once per frame
    void Update()
    {
        if (a == true && b == true && c == true)
        {
            check3 = true;
        }
    }

    private void OnTriggerStay2D(Collider2D fruit)
    {
        if (fruit.gameObject.tag == "C1")
        {
            a = true;
        }
        if (fruit.gameObject.tag == "C2")
        {
            b = true;
        }
        if (fruit.gameObject.tag == "C3")
        {
            c = true;
        }

    }
}
