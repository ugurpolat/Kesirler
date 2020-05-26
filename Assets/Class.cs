using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Class : MonoBehaviour
{
    public AudioSource teacherTalk;
    public GameObject obj1, obj2;
    public float timer = 3.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TeacTalk()
    {
        teacherTalk.Play();
        while (timer > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }
        if (timer <= 0)
        {
            obj1.SetActive(true);
            obj2.SetActive(true);

        }
    }

    public void StartTalk()
    {

        StartCoroutine("TeacTalk");
    }

    public void OpenFractions()
    {

        StartTalk();
    }
}
