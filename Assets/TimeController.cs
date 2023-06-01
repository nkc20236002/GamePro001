using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    GameObject TimeGauge;

    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    void Update()
    {
        this.TimeGauge.GetComponent<Image>();
        this.TimeGauge -= Time.deltaTime;
    }
}
