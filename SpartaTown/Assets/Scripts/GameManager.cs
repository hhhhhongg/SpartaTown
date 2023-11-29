using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;   
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public Text currentTimeText;

    

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;

        string fmTime = currentTime.ToString("HH:mm:ss");

        currentTimeText.text = $"{fmTime}";

    }
}
