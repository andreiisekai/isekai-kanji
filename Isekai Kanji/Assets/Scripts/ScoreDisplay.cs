using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreTMP;
    [SerializeField] GameStats stats;
    // Start is called before the first frame update
    void Start()
    {
        scoreTMP.text = "Your score: "+stats.Score;
    }

}
