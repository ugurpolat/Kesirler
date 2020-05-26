using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCheckFull : MonoBehaviour
{
    public bool a, b, c, d;
    public bool check1 = false;
   
    // Update is called once per frame
    void Update()
    {
        if (a==true && b==true && c == true && d == true)
        {
            check1 = true;
            
              
        }
    }

    private void OnTriggerStay2D(Collider2D fruit)
    {
        if (fruit.gameObject.tag == "T1")
        {
            a = true;
            
            
        }
        if (fruit.gameObject.tag == "T2")
        {
            b = true;
            
        }
        if (fruit.gameObject.tag == "T3")
        {
            c = true;
            
        }
        if (fruit.gameObject.tag == "T4")
        {
            d = true;
            
        }
       
    }
   
}
