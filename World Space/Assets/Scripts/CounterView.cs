using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    TextMeshProUGUI TextComp;
    int currentValue;

    void Start()
    {
        TextComp = GetComponent<TextMeshProUGUI>();

    }

   public void TickUpCounter(int tickUpValue)
    {
        currentValue += tickUpValue;
        TextComp.text = $": {currentValue}";
    }
}
