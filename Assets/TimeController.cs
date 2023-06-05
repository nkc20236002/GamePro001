using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    GameObject TimeGauge;
    float delta = 0;
    float span = 1.0f;

    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    void Update()
    {
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                this.TimeGauge.GetComponent<Image>().fillAmount -= 0.009f;
            }

            this.delta += Time.deltaTime;


        }


    }
}
