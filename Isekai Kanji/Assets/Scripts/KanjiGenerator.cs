using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiGenerator : MonoBehaviour
{
    [SerializeField] private JLPT jlptn5;
    [SerializeField] private KanaSystem hiragana, katakana;
    public Kanji GetRandomKanji(KanjiSettings settings)
    {
        var randKanjiList = new List<Kanji>();
        
        if (settings.Jlpnt5Toggle) 
        { 
            int randomIndex = Random.Range(0, jlptn5.kanji.Length);
            randKanjiList.Add(jlptn5.kanji[randomIndex]);
        }

        if (settings.HiraganaToggle)
        {
            int randomIndex = Random.Range(0, hiragana.kana.Length);
            randKanjiList.Add(new Kanji(hiragana.kana[randomIndex]));
        }

        if (settings.KatakanaToggle)
        {
            int randomIndex = Random.Range(0, katakana.kana.Length);
            randKanjiList.Add(new Kanji(katakana.kana[randomIndex]));
        }

        return randKanjiList[Random.Range(0, randKanjiList.Count)];
    }
}
