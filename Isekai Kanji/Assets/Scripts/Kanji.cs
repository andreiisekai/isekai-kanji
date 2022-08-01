using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Kanji
{
    [SerializeField]
    private string symbol;

    [Tooltip("On-yomi: Borrowed Chinese readings that are generaly used in compound kanji.")]
    [SerializeField]
    private List<string> onyomi;

    [Tooltip("Kun-yomi: Japanese reading.")]
    [SerializeField]
    private List<string> kunyomi;

    [SerializeField]
    private List<string> meaning;

    public string Symbol { get => symbol; }
    public List<string> Onyomi { get => onyomi; }
    public List<string> Kunyomi { get => kunyomi; }
    public List<string> Meaning { get => meaning; }
}
