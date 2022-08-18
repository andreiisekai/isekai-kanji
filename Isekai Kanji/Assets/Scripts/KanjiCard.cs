using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KanjiCard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI kanjiSymbol, onyomiRomaji, onyomiKana, kunyomiRomaji, kunyomiKana, meaning;
    [SerializeField] JLPT jlptn5;
    
    public void FillKanjiCard(Kanji kanji)
    {
        kanjiSymbol.text = kanji.Symbol;
        onyomiRomaji.text = string.Join(", ", kanji.Onyomi);
        onyomiKana.text = string.Join(", ", kanji.Onyomi);
        kunyomiRomaji.text = string.Join(", ", kanji.Kunyomi);
        kunyomiKana.text = string.Join(", ", kanji.Kunyomi);
        meaning.text = string.Join(", ", kanji.Meaning);
    }

}
