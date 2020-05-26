using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Hint : MonoBehaviour
{
    float timer = 1;
    public GameObject hintPanel;
    public AudioSource hintVoice;
    public AudioSource bg;
    public void HintPanel()
    {
        timer = 1;
        hintPanel.SetActive(true);
        bg.GetComponent<AudioSource>().volume = 0.1f;
        StarVoice();
    }
    private void Update()
    {
        
    }
    IEnumerator HintVoiceStart()
    {
        while (timer > 0)
        {
            yield return new WaitForSeconds(1.5f);
            timer--;
            hintVoice.Play();
            yield return new WaitForSeconds(17f);
        }
        if (timer <= 0)
        {
            hintPanel.SetActive(false);
            
        }
        
    }

    public void StarVoice()
    {
        StartCoroutine("HintVoiceStart");
    }    
}
