using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score = 0, lives = 5, kanjiScore = 10;
    [SerializeField] TextMeshProUGUI scoreTMP, livesTMP;
    [SerializeField] SceneLoader sceneLoader;

    public int Lives { get => lives; private set => lives = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStats();
        if (Lives == 0)
        {
            sceneLoader.LoadGameOver();
        }
    }

    public void AddToScore()
    {
        score += kanjiScore;
    }

    public void RemoveLives()
    {
        Lives--;
    }

    void UpdateStats()
    {
        scoreTMP.text = score.ToString();
        livesTMP.text = lives.ToString();
    }
}
