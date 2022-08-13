using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameStats", fileName = "GameStats")]
public class GameStats : ScriptableObject
{
    public int Score;
    public int Lives;
    public int KanjiScore;
}
