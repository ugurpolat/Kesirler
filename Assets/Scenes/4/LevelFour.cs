using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelFour : MonoBehaviour
{
    float timer = 5;
    public AudioSource hint, question,ok,wrong;
    public GameObject panel1;
    public Button qBut, hBut;
    public Button correct1, correct2, wrong1;
    public GameObject NextButton,hand;
    bool a, b;

    // Start is called before the first frame update
    void Start()
    {
        qBut.interactable = false;
        hBut.interactable = false;
        correct1.interactable = false;
        correct2.interactable = false;
        wrong1.interactable = false;
        question.Play();
        StartWaitSeconds();
    }

    IEnumerator WaitSeconds()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }
       
        if (timer <=0)
        {
            panel1.SetActive(false);
            qBut.interactable = true;
            hBut.interactable = true;
            correct1.interactable = true;
            correct2.interactable = true;
            wrong1.interactable = true;
            hand.SetActive(true);
        }

    }
    public void StartWaitSeconds()
    {
        StartCoroutine("WaitSeconds");
    }
    // Update is called once per frame
    void Update()
    {
        if (a == true && b == true)
        {
            NextButton.SetActive(true);
        }
    }
    public void CorrectOne()
    {
        a = true;
        correct1.interactable = false;
        hand.SetActive(false);
        ok.Play();


    }
    public void CorrectTwo()
    {
        b = true;
        correct2.interactable = true;
        ok.Play();
    }
    public void QuestionShow()
    {
        qBut.interactable = false;
        hBut.interactable = false;
        correct1.interactable = false;
        correct2.interactable = false;
        wrong1.interactable = false;
        panel1.SetActive(true);
        question.Play();
        StartWaitSeconds();
    }
    public void ShowHint()
    {
        hint.Play();
    }

    public void Wrong()
    {
        wrong.Play();
    }
}
