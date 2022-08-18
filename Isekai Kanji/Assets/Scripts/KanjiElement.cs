using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiElement : MonoBehaviour
{
    UIHandler handler;
    Kanji kanji;

    public Kanji Kanji { get => kanji; set => kanji = value; }

    // Start is called before the first frame update
    void Start()
    {
        handler = FindObjectOfType<UIHandler>();
    }
    
    public void ShowCard()
    {
        KanjiCard card = handler.ShowKanjiCardCanvas();
        card.FillKanjiCard(Kanji);
    }
}
