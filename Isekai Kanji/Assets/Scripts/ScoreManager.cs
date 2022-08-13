using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] GameStats stats;
    private int lives = 1, kanjiScore = 1;
    [SerializeField] TextMeshProUGUI scoreTMP, livesTMP;
    [SerializeField] SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {
        stats.Score = 0;
        lives = stats.Lives;
        kanjiScore = stats.KanjiScore;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStats();
        if (lives == 0)
        {
            sceneLoader.LoadGameOver();
        }
    }

    public void AddToScore()
    {
        stats.Score += kanjiScore;
    }

    public void RemoveLives()
    {
        lives--;
    }

    void UpdateStats()
    {
        scoreTMP.text = stats.Score.ToString();
        livesTMP.text = lives.ToString();
    }
}
