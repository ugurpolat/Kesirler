using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Plate1 : MonoBehaviour
{
    public int a = 0;
    public bool check1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a ==3)
        {
            check1 = true;
        }
        else
        {
            check1 = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.tag == "pizza")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza2")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza3")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza4")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza5")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza6")
        {
            a++;
        }
        else if (co.gameObject.tag == "pizza7")
        {
            a++;
        }

    }
    
    private void OnTriggerExit2D(Collider2D co)
    {
        if (co.gameObject.tag == "pizza")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza2")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza3")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza4")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza5")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza6")
        {
            a--;
        }
        else if (co.gameObject.tag == "pizza7")
        {
            a--;
        }
    }
}
