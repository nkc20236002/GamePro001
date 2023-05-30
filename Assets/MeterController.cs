using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterManager : MonoBehaviour
{
    GameObject Meter;
    int score_num = 0; 
    void Start()
    {
        this.Meter = GameObject.Find("MeterGauge");
    }

    void Update()
    {
        Text MeterGauge = Meter.GetComponent<Text>();
        MeterGauge.text = score_num + "km";

        score_num += 1; 
    }
}
