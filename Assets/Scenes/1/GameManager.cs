using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timer =10;
    public GameObject NextButton;
    FruitCheckFull myFull;
    FruitCheckHalf myHalf;
    FruitCheckQuarter myQuarter;
    public GameObject helpPanel;
    public AudioSource Appl;
    bool a = true;
    // Start is called before the first frame update
    void Start()
    {
        myFull = GameObject.Find("MainBox2").GetComponentInChildren<FruitCheckFull>();
        myHalf = GameObject.Find("MainBox3").GetComponentInChildren<FruitCheckHalf>();
        myQuarter = GameObject.Find("MainBox4").GetComponentInChildren<FruitCheckQuarter>();
        //helpPanel.SetActive(true);
        StartHelp();
    }

    // Update is called once per frame
    void Update()
    {
        if (myFull.check1==true && myHalf.check2 == true && myQuarter.check3==true)
        {
            NextButton.SetActive(true);
            if (a == true)
            {
                Appl.Play();
                a = false;
            }
            
        }
    }

    IEnumerator HelpPanelShow()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(0.5f);
            timer--;
           
            
        }
        if (timer <= 0)
        {
            helpPanel.SetActive(false);

        }
    }

    public void StartHelp()
    {
        StartCoroutine("HelpPanelShow");
    }
}
