using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] GameObject TimesUpScreen;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] float duration, currentTime;

    void Start()
    {
        TimesUpScreen.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while (currentTime >=0)
        {
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        OpenPanel();
    }

    void OpenPanel()
    {
        timeText.text = "";
        TimesUpScreen.SetActive(true);
    }

}
