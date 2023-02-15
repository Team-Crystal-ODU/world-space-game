using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class XpView : MonoBehaviour
{
    TextMeshProUGUI TextComp;
    public int maxXP;
    int currentXp;
    int currentLevel;

    void Start()
    {
        TextComp = GetComponent<TextMeshProUGUI>();

    }

    public void TickUpXp(int tickUpValue)
    {
        currentXp += tickUpValue;

        if(currentXp >= maxXP)
        {
            currentXp = 0;
            currentLevel++;
        }

        TextComp.text = $"Level: {currentLevel} {Environment.NewLine}XP: {currentXp}/{maxXP}";

    }
}