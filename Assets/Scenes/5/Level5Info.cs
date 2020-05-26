using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Level5Info : MonoBehaviour
{
    public GameObject panel1, panel2, panel3, panel4, panel5,panel6,panelMaterial;
    public float timer = 2;
    public float timer2 = 3;
    public float timer3 = 2;
    float timer4 = 10;

    public AudioSource kid, father, father2;
    public Button fatherButton;
    public GameObject NextButton, NextButton2, hit;

    public Button egg1, egg2, egg3, egg4, egg5;
    public Button flour1, flour2, flour3, flour4;
    public Button oil1, oil2, oil3, oil4, oil5;
    public Button sausage1, sausage2;
    public Button cheese1, cheese2,cheese3,cheese4,cheese5;

    public Button eggCheck, flourCheck, oilCheck, sausageCheck,cheeseCheck;

    public GameObject dough, che, saug;
    public GameObject ok1, ok2, ok3, ok4,ok5, wrong1, wrong2, wrong3, wrong4,wrong5;




    public int eggcounter = 0;
    public int flourcounter = 0;
    public int oilcounter = 0;
    public int sausagecounter = 0;
    public int cheesecounter = 0;



    public void Egg1()
    {
         egg1.interactable = false;
         eggcounter++;

    }
    public void Egg2()
    {
        egg2.interactable = false;
        eggcounter++;

    }
    public void Egg3()
    {
        egg3.interactable = false;
        eggcounter++;

    }
    public void Egg4()
    {
        egg4.interactable = false;
        eggcounter++;

    }
    public void Egg5()
    {
        egg5.interactable = false;
        eggcounter++;

    }
    
    public void Flour1()
    {
        flour1.interactable = false;
        flourcounter++;
    }
    public void Flour2()
    {
        flour2.interactable = false;
        flourcounter++;
    }
    public void Flour3()
    {
        flour3.interactable = false;
        flourcounter++;
    }
    public void Flour4()
    {
        flour4.interactable = false;
        flourcounter++;
    }

    public void Oil1()
    {
        oil1.interactable = false;
        oilcounter++;
    }
    public void Oil2()
    {
        oil2.interactable = false;
        oilcounter++;
    }
    public void Oil3()
    {
        oil3.interactable = false;
        oilcounter++;
    }
    public void Oil4()
    {
        oil4.interactable = false;
        oilcounter++;
    }
    public void Oil5()
    {
        oil5.interactable = false;
        oilcounter++;
    }
    
    public void Sausage1()
    {
        sausage1.interactable = false;
        sausagecounter++;
    }
    public void Sausage2()
    {
        sausage2.interactable = false;
        sausagecounter++;
    }
    public void Cheese1()
    {
        cheese1.interactable = false;
        cheesecounter++;
    }
    public void Cheese2()
    {
        cheese2.interactable = false;
        cheesecounter++;
    }
    public void Cheese3()
    {
        cheese3.interactable = false;
        cheesecounter++;
    }
    public void Cheese4()
    {
        cheese4.interactable = false;
        cheesecounter++;
    }
    public void Cheese5()
    {
        cheese5.interactable = false;
        cheesecounter++;
    }
    public void CheeseCheck()
    {
        if (cheesecounter == 3)
        {
            cheese1.interactable = false;
            cheese2.interactable = false;
            cheese3.interactable = false;
            cheese4.interactable = false;
            cheese5.interactable = false;
            che.SetActive(true);
            ok5.SetActive(true);
            NextButton2.SetActive(true);
            

        }
        else
        {
            cheese1.interactable = true;
            cheese2.interactable = true;
            cheese3.interactable = true;
            cheese4.interactable = true;
            cheese5.interactable = true;
            cheesecounter = 0;
            wrong5.SetActive(true);
            StartCount5();
        }
    }
    public void SausageCheck()
    {
        if (sausagecounter == 1)
        {
            cheese1.interactable = true;
            cheese2.interactable = true;
            cheese3.interactable = true;
            cheese4.interactable = true;
            cheese5.interactable = true;
            saug.SetActive(true);
            ok4.SetActive(true);
            cheeseCheck.interactable = true;

            sausage1.interactable = false;
            sausage2.interactable = false;
            sausageCheck.interactable = false;
        }
        else
        {
            sausage1.interactable = true;
            sausage2.interactable = true;
            sausagecounter = 0;
            wrong4.SetActive(true);
            StartCount4();
        }
    }
    public void EggCheck()
    {
        if (eggcounter == 4)
        {
            flour1.interactable = true;
            flour2.interactable = true;
            flour3.interactable = true;
            flour4.interactable = true;
            flourCheck.interactable = true;
            egg1.interactable = false;
            egg2.interactable = false;
            egg3.interactable = false;
            egg4.interactable = false;
            egg5.interactable = false;
            eggCheck.interactable = false;
            ok1.SetActive(true);
        }
        else { 
            egg1.interactable = true;
            egg2.interactable = true;
            egg3.interactable = true;
            egg4.interactable = true;
            egg5.interactable = true;
            eggcounter = 0;
            wrong1.SetActive(true);
            StartCount();
            


        }
    }
    public void FlourCheck()
    {
        if (flourcounter == 2)
        {
            oil1.interactable = true;
            oil2.interactable = true;
            oil3.interactable = true;
            oil4.interactable = true;
            oil5.interactable = true;
            ok2.SetActive(true);
            oilCheck.interactable = true;

            flour1.interactable = false;
            flour2.interactable = false;
            flour3.interactable = false;
            flour4.interactable = false;
            flourCheck.interactable = false;
        }
        else
        {
            flour1.interactable = true;
            flour2.interactable = true;
            flour3.interactable = true;
            flour4.interactable = true;
            flourcounter = 0;
            wrong2.SetActive(true);
            StartCount2();
        }
    }
    public void OilCheck()
    {
        if (oilcounter ==1)
        {
            sausage1.interactable = true;
            sausage2.interactable = true;
            sausageCheck.interactable = true;
            dough.SetActive(true);
            ok3.SetActive(true);
            oil1.interactable = false;
            oil2.interactable = false;
            oil3.interactable = false;
            oil4.interactable = false;
            oil5.interactable = false;
            
            oilCheck.interactable = false;

        }
        else
        {
            oil1.interactable = true;
            oil2.interactable = true;
            oil3.interactable = true;
            oil4.interactable = true;
            oil5.interactable = true;
            
            
            oilcounter = 0;
            wrong3.SetActive(true);
            StartCount3();
        }
    }


    IEnumerator Count()
    {
        while (timer3 > 0)
        {
            yield return new WaitForSeconds(1f);
            timer3--;
        }
        if (timer3<=0)
        {
            
            timer3 = 2;
            wrong1.SetActive(false);
        }
    }
    IEnumerator Count2()
    {
        while (timer3 > 0)
        {
            yield return new WaitForSeconds(1f);
            timer3--;
        }
        if (timer3 <= 0)
        {

            timer3 = 2;
            wrong2.SetActive(false);
        }
    }
    IEnumerator Count3()
    {
        while (timer3 > 0)
        {
            yield return new WaitForSeconds(1f);
            timer3--;
        }
        if (timer3 <= 0)
        {

            timer3 = 2;
            wrong3.SetActive(false);
        }
    }
    IEnumerator Count4()
    {
        while (timer3 > 0)
        {
            yield return new WaitForSeconds(1f);
            timer3--;
        }
        if (timer3 <= 0)
        {

            timer3 = 2;
            wrong4.SetActive(false);
        }
    }

    IEnumerator Count5()
    {
        while (timer3 > 0)
        {
            yield return new WaitForSeconds(1f);
            timer3--;
        }
        if (timer3 <= 0)
        {

            timer3 = 2;
            wrong5.SetActive(false);
        }
    }

    void StartCount()
    {
        StartCoroutine("Count");
    }
    void StartCount2()
    {
        StartCoroutine("Count2");
    }
    void StartCount3()
    {
        StartCoroutine("Count3");
    }
    void StartCount4()
    {
        StartCoroutine("Count4");
    }
    void StartCount5()
    {
        StartCoroutine("Count5");
    }
    // Start is called before the first frame update
    void Start()
    {
        if (panel1.activeSelf)
        {
        StartBusCountDown();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BusCountDown()
    {
        while (timer > 0)
        {
            
            yield return new WaitForSeconds(1f);
            timer--;
        }
        if (timer <= 0)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            yield return new WaitForSeconds(3f);
            panel2.SetActive(false);
            panel3.SetActive(true);
        }
        
    }
    IEnumerator BusCountDown2()
    {
        while (timer2 > 0)
        {

            yield return new WaitForSeconds(1f);
            timer2--;
        }
        if (timer2 <= 0)
        {
            panel4.SetActive(false);
            panel5.SetActive(true);
        }
        

    }

    public void StartBusCountDown2()
    {
        StartCoroutine("BusCountDown2");
    }

    public void StartBusCountDown()
    {
        StartCoroutine("BusCountDown");
    }
    public void KidTalk()
    {
        kid.Play();
        if (kid.isPlaying)
        {
            fatherButton.interactable = true;
        }
    }

    public void FatherTalk()
    {
        father.Play();
        if(father.isPlaying){
            NextButton.SetActive(true);
        }
    }

    public void OpenPanelFour()
    {
        panel3.SetActive(false);
        panel4.SetActive(true);
    }
    
    public void FatherTalkTwo()
    {
        father2.Play();
        StartBusCountDown2();
        
    }

    IEnumerator HitDown()
    {
        while (timer4 > 0)
        {

            yield return new WaitForSeconds(1f);
            timer4--;
        }
        if (timer4 <= 0)
        {
            hit.SetActive(false);
        }

    }
    void StartHit()
    {
        StartCoroutine("HitDown");
    }

    public void OpenRecipePanel()
    {
        panel6.SetActive(true);
        hit.SetActive(true);
        panelMaterial.SetActive(true);
        StartHit();
    }
    public void CloseRecipePanel()
    {
        panel6.SetActive(false);
    }





}
