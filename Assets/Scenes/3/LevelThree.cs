using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelThree : MonoBehaviour
{
    float timer = 1;
    public Text result, result2, result3, result4;
    public InputField inputField1, inputField2, inputField3, inputField4,
                      inputField5, inputField6, inputField7, inputField8;
    public GameObject panel1, panel2, panel3, panel4;
    public GameObject NextButton;

    TouchScreenKeyboard myKeyboard;

    public void OpenKeyboard()
    {
        myKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TouchScreenKeyboard.visible == false && myKeyboard != null)
        {
            if (myKeyboard.done)
            {
                myKeyboard = null;
            }
        }

    }
    IEnumerator CountDown(GameObject p1, GameObject p2)
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }
        if (timer == 0)
        {
            p1.SetActive(false);
            p2.SetActive(true);
        }

    }
    public void StarCountDown(GameObject a, GameObject b)
    {
        StartCoroutine(CountDown(a, b));
    }

    public void PanelOne()
    {
        if (inputField1.text == "2" && inputField2.text == "4")
        {
            result.GetComponent<Text>().color = Color.green;
            result.text = "DOĞRU";
            timer = 1;
            StarCountDown(panel1, panel2);

        }
        else
        {
            result.GetComponent<Text>().color = Color.red;
            result.text = "YANLIŞ";
            inputField1.text = "";
            inputField2.text = "";
        }
    }
    public void PanelTwo()
    {
        if (inputField3.text == "3" && inputField4.text == "4")
        {
            result2.GetComponent<Text>().color = Color.green;
            result2.text = "DOĞRU";
            timer = 1;
            StarCountDown(panel2, panel3);

        }
        else
        {
            result2.GetComponent<Text>().color = Color.red;
            result2.text = "YANLIŞ";
            inputField3.text = "";
            inputField4.text = "";
        }
    }
    public void PanelThree()
    {
        if (inputField5.text == "3" && inputField6.text == "5")
        {
            result3.GetComponent<Text>().color = Color.green;
            result3.text = "DOĞRU";
            timer = 1;
            StarCountDown(panel3, panel4);

        }
        else
        {
            result3.GetComponent<Text>().color = Color.red;
            result3.text = "YANLIŞ";
            inputField5.text = "";
            inputField6.text = "";
        }
    }
    public void PanelFour()
    {
        if (inputField7.text == "5" && inputField8.text == "9")
        {
            result4.GetComponent<Text>().color = Color.green;
            result4.text = "DOĞRU";
            timer = 1;
            NextButton.SetActive(true);

        }
        else
        {
            result4.GetComponent<Text>().color = Color.red;
            result4.text = "YANLIŞ";
            inputField7.text = "";
            inputField8.text = "";
        }
    }


     
    
}