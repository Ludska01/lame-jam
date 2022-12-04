using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerScrpt : MonoBehaviour
{

    float timeLeft;
    [SerializeField]
    float cooldownTime;
    [SerializeField]
    TMP_Text coundownText;
    [SerializeField]
    TMP_Text wholeTime;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = cooldownTime;
    }

    // Update is called once per frame
    void Update()
    {
        wholeTime.text = "Time : " + ((int)Time.time) + "s";
        timeLeft -= (1 * Time.deltaTime);
        coundownText.text = "Time till next wave: " + ((int)timeLeft).ToString() + "s"; 

        if(timeLeft <= 0)
        {
            timeLeft = (int)cooldownTime;
        }
    }
}
