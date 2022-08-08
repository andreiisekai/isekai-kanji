using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private KanjiSpawner kanjiSpawner;
    public List<KanjiDisplay> displayedKanjis;
    private bool hasActiveKanji;
    private KanjiDisplay activeKanji;
    [SerializeField] ScoreManager scoreManager;

    public void AddKanji()
    {
        KanjiDisplay display = kanjiSpawner.SpawnKanjiDisplay();
        displayedKanjis.Add(display);
    }

    public void RemoveKanjiFromList(KanjiDisplay display)
    {
        hasActiveKanji = false;
        Destroy(display.gameObject);
        displayedKanjis.Remove(display);
    }

    public void RemoveKanjiAndLives(KanjiDisplay display)
    {
        RemoveKanjiFromList(display);
        scoreManager.RemoveLives();
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
            RemoveKanjiFromList(activeKanji);
            scoreManager.AddToScore();
        }
    }
}
