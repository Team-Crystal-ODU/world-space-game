using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarView : MonoBehaviour
{
    Image bar;

    void Start()
    {
        bar = GetComponent<Image>();  
    }

    public void TickUpBar(float tickupvalue)
    {
        float currentValue = bar.fillAmount + tickupvalue;
        if(currentValue > 1)
        {
            bar.fillAmount = 0;
        }
        else
        {
            bar.fillAmount = currentValue;
        }

    }
}
