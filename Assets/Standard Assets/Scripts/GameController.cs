﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

    public GUIText countText;
    public GUIText winText;
    public GUIText timeText;
    public int amountNeededToEndTheGame = 12;
    private int count = 0;
    private float currentPlayTime = 0;
    

	// Use this for initialization
	void Start () {
        instance = this;
        SetCountText();
        winText.text = "";
        SetPlayTimeText();
    }
    void Update()
    {
        UpdatePlayTime();
    }

    public void TouchedAPickup()
    {
        count += 1;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= amountNeededToEndTheGame)
        {
            winText.text = "YOU WIN";
        }
    }
    void UpdatePlayTime()
    {
        currentPlayTime += Time.deltaTime;
        SetPlayTimeText();
    }
    void SetPlayTimeText()
    {
        timeText.text = "your time: " + currentPlayTime.ToString();
    }
    
}
