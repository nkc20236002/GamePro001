using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Timegauge;
    void Start()
    {
        this.Timegauge = GameObject.Find("Time_gauge");
    }

    public void DecreaseTime()
    {
        this.Timegauge.GetComponent<Image>().fillAmount -= 0.1f; 
    }
}
