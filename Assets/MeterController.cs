using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MeterController : MonoBehaviour
{
    GameObject MeterGauge;
    public float score = 0;

    void Start()
    {
        this.MeterGauge = GameObject.Find("MeterGauge");
        TextMeshProUGUI Meter = MeterGauge.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        TextMeshProUGUI Meter = MeterGauge.GetComponent<TextMeshProUGUI>();
        score += 0.1f;
        Meter.text = score.ToString("F1") + "km";

    }
}
