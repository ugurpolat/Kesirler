using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class LevelSix : MonoBehaviour
{
    public GameObject NextButton,Panel,hint;
    Plate1 myPlate1;
    Plate2 myPlate2;
    Plate3 myPlate3;
    Plate4 myPlate4;

    public float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartHint();
        myPlate1 = GameObject.Find("plate1").GetComponent<Plate1>();
        myPlate2 = GameObject.Find("plate2").GetComponent<Plate2>();
        myPlate3 = GameObject.Find("plate3").GetComponent<Plate3>();
        myPlate4 = GameObject.Find("plate4").GetComponent<Plate4>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlate1.check1== true&&myPlate2.check2 == true&&myPlate3.check3==true&&myPlate4.check4==true)
        {
            NextButton.SetActive(true);
            
        }
    }

    public void OpenLastPanel()
    {
        Panel.SetActive(true);
    }

    IEnumerator HintCount()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }
        if (timer <=0)
        {
            
            hint.SetActive(false);
        }
    }

    void StartHint()
    {
        StartCoroutine("HintCount");
    }
}
