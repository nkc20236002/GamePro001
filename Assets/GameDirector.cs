using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
    GameObject meter;

    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }
    public void DecreaseTime()
    {
        Debug.Log("DecreaseTime");
        this.TimeGauge.GetComponent<Image>().fillAmount -= 0.1f;


    }
}
