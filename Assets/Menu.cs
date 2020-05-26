using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject NextButton;
    float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartSeconds();
    }

    IEnumerator WaitSeconds()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }

        if (timer <= 0)
        {
            NextButton.SetActive(true);
        }

    }
     void StartSeconds()
    {
        StartCoroutine("WaitSeconds");
    }
}
