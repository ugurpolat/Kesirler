using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShow : MonoBehaviour
{
    float timer = 4;
    public GameObject a1, a2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            a1.SetActive(true);
            a2.SetActive(true);
        }
    }
}
