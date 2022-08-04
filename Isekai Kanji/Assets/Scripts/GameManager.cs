using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private KanjiSpawner kanjiSpawner;
    public List<KanjiDisplay> displayedKanjis;
    private bool hasActiveKanji;
    private KanjiDisplay activeKanji;

    public void AddKanji()
    {
        KanjiDisplay display = kanjiSpawner.SpawnKanjiDisplay();
        Debug.Log(display.Kanji.Meaning[0]);
        displayedKanjis.Add(display);
    }

    public void RemoveKanjiFromList(KanjiDisplay display)
    {
        Destroy(display.gameObject);
        displayedKanjis.Remove(display);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveKanji)
        {
            if (activeKanji.GetNextLetter() == letter)
            {
                activeKanji.TypeLetter();
            }
        }
        else
        {
            foreach(var kanji in displayedKanjis)
            {
                if (kanji.GetNextLetter() == letter)
                {
                    activeKanji = kanji;
                    hasActiveKanji = true;
                    kanji.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveKanji && activeKanji.KanjiTyped)
        {
            hasActiveKanji = false;
            RemoveKanjiFromList(activeKanji);
        }
    }
}
