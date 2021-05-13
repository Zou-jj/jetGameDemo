using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private int score;
    GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        score = 0;
        ui = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int score)
    {
        this.score += score;
        ui.SendMessage("UpdateScore", this.score);
    }
}
