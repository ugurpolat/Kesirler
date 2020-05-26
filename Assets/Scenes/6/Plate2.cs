using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Plate2 : MonoBehaviour
{
    public int b = 0;
    public bool check2 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (b == 1)
        {
            check2 = true;
        }
        else
        {
            check2 = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.tag == "pizza")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza2")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza3")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza4")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza5")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza6")
        {
            b++;
        }
        else if (co.gameObject.tag == "pizza7")
        {
            b++;
        }

    }

    private void OnTriggerExit2D(Collider2D co)
    {
        if (co.gameObject.tag == "pizza")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza2")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza3")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza4")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza5")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza6")
        {
            b--;
        }
        else if (co.gameObject.tag == "pizza7")
        {
            b--;
        }
    }
}
