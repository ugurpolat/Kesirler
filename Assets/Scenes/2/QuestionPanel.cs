using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPanel : MonoBehaviour
{
    float timer = 5;
    public GameObject questionPanel;
    public GameObject questionButton;
    LevelTwo myLevelTwo;
    // Start is called before the first frame update
    void Start()
    {
        myLevelTwo = GameObject.Find("GM").GetComponent<LevelTwo>();
        myLevelTwo.ButtonsClose();
        StartQuestion();
    }

    IEnumerator QuestionPanelShow() 
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(0.5f);
            timer--;
        }
        if (timer <=0)
        {
            questionPanel.SetActive(false);
            questionButton.SetActive(true);
            myLevelTwo.ButtonsOpen();
        }
    }
    public void StartQuestion()
    {
        StartCoroutine("QuestionPanelShow");
    }
    public void Show()
    {
        myLevelTwo.ButtonsClose();
        questionPanel.SetActive(true);
        timer = 5;
        questionButton.SetActive(false);
        StartQuestion();
    }
}
