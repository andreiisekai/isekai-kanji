using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class KanaParser : MonoBehaviour
{
    [SerializeField] private KanaSystem hiragana;
    [SerializeField] private KanaSystem katakana;

    public string Parse(string kanas)
    {
        kanas = GetRomajiFromKana(kanas, hiragana);
        kanas = GetRomajiFromKana(kanas, katakana);

        return kanas;
    }

    private string GetRomajiFromKana(string kanas, KanaSystem kanaSystem)
    {
        foreach (var kana in kanaSystem.kana)
        {
            kanas = kanas.Replace(kana.Symbol, kana.Romaji);
        }
        return kanas;
    }
}
