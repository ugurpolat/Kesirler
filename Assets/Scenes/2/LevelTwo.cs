using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwo : MonoBehaviour
{
    // Start is called before the first frame update

    public Button[] myButton= new Button[9];

    public AudioSource True1;
    public AudioSource False1;
    public AudioSource True2;
    public AudioSource False2;

    public GameObject image1;
    public GameObject image2;
    public GameObject image3;


    bool a, b, c;
    public GameObject NextButton;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (a == true && b == true && c == true )
        {
            NextButton.SetActive(true);
        }
    }

    public void CorrectAnswer()
    {
        True1.Play();
        image1.SetActive(true);
        a = true;
    }
    public void CorrectAnswer2()
    {
        True2.Play();
        image2.SetActive(true);
        b = true;
    }
    public void CorrectAnswer3()
    {
        True1.Play();
        image3.SetActive(true);
        c = true;
    }
    public void WrongAnswer()
    {
        False1.Play();
    }
    public void WrongAnswer2()
    {
        False2.Play();
    }

   public void ButtonsOpen()
    {
        myButton[0].interactable = true;
        myButton[1].interactable = true;
        myButton[2].interactable = true;
        myButton[3].interactable = true;
        myButton[4].interactable = true;
        myButton[5].interactable = true;
        myButton[6].interactable = true;
        myButton[7].interactable = true;
        myButton[8].interactable = true;
    }
   public void ButtonsClose()
    {
        myButton[0].interactable = false;
        myButton[1].interactable = false;
        myButton[2].interactable = false;
        myButton[3].interactable = false;
        myButton[4].interactable = false;
        myButton[5].interactable = false;
        myButton[6].interactable = false;
        myButton[7].interactable = false;
        myButton[8].interactable = false;
    }
}
