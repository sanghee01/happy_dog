using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testfeeder : MonoBehaviour
{
    public Slider slide;
    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Fourth;
    /*public GameObject Animobj;*/
    public int score, count;

    private void Start()
    {
        if (slide.value < 60) //허기 비율 60미만이면
        {
            First.SetActive(true); //1번 배고픈모습만 ON
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
            count = 0;

        }
        else //허기 비율 60이상
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(true);
            count = 0;

        }
    }

    public void One_Food() // 버튼 클릭 이벤트
    {
        count++;
        First.SetActive(false);
        Second.SetActive(true);
        Third.SetActive(false);
        Fourth.SetActive(false);
        score = 10;
        StartCoroutine(mulbangowl());
        slide.value += score;
        // DB재료 - 1

    }

    public void Two_Food()
    {
        count++;
        First.SetActive(false);
        Second.SetActive(true);
        Third.SetActive(false);
        Fourth.SetActive(false);
        score = 20;
        StartCoroutine(mulbangowl());
        slide.value += score;
        // DB재료 - 1

    }

    public void One_Snack()
    {
        count++;
        First.SetActive(false);
        Second.SetActive(true);
        Third.SetActive(false);
        Fourth.SetActive(false);
        score = 5;
        StartCoroutine(mulbangowl());
        slide.value += score;


        // DB재료 - 1

    }

    public void Two_Snack() // 버튼 클릭 이벤트
    {
        count++;
        First.SetActive(false);
        Second.SetActive(true);
        Third.SetActive(false);
        Fourth.SetActive(false);
        score = 10;
        StartCoroutine(mulbangowl());
        slide.value += score;
        // DB재료 - 1

    }
    IEnumerator mulbangowl()
    {
        yield return new WaitForSeconds(3.0f);
        valuecheck();
    }

    public void valuecheck() // 현재 슬라이더값 체킹
    {
        if (slide.value < 60)
        {
            First.SetActive(true);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
        }
        else
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(true);
        }

    }
}

