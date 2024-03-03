using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level_UI : MonoBehaviour
{
    public TextMeshProUGUI TXT_Wave;

    public void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        TXT_Wave.text = $"Wave : {WaveManager.instance.actualWave}/ {WaveManager.instance.waveNbr}";
    }
}
