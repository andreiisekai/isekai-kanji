using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiGenerator : MonoBehaviour
{
    [SerializeField] private JLPT jlpt1;
    public Kanji GetRandomKanji()
    {
        int randomIndex = Random.Range(0, jlpt1.kanji.Length);
        return jlpt1.kanji[randomIndex];
    }
}
