using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public Text scoreText;
    public GameObject Goal;
	
    int score = 0;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            scoreText.text = "Fire left: " + score;
        }
    }

    public static ScoreManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Score = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score == 0)
        {
            Goal.SetActive(true);
        }
    }
}
