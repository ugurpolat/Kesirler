using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCheckHalf : MonoBehaviour
{

    bool a, b;
    public bool check2 = false;
    // Update is called once per frame
    void Update()
    {
        if (a == true && b == true )
        {
            check2 = true;
        }
    }

    private void OnTriggerStay2D(Collider2D fruit)
    {
        if (fruit.gameObject.tag == "Y1")
        {
            a = true;
        }
        if (fruit.gameObject.tag == "Y2")
        {
            b = true;
        }
        

    }
}
