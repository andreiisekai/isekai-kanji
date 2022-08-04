using System;
using UnityEngine;

[Serializable]
public class Kana 
{
    [SerializeField] private string symbol;
    [SerializeField] private string romaji;

    public string Symbol { get => symbol;}
    public string Romaji { get => romaji;}
}
