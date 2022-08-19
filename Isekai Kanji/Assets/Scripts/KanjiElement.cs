using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KanjiElement : MonoBehaviour
{
    UIHandler handler;
    Kanji kanji;

    public Kanji Kanji { get => kanji; set => kanji = value; }

    // Start is called before the first frame update
    void Start()
    {
        handler = FindObjectOfType<UIHandler>();
        if (Kanji.Meaning == null)
        {
            var button = GetComponent<Button>();
            Destroy(button);
            var symbol = gameObject.GetComponentInChildrenByName <TextMeshProUGUI> ("Symbol");
            if (symbol.text.Length > 1)
            {
                symbol.fontSize = 37.5f;
            }
        }
    }
    
    public void ShowCard()
    {
        KanjiCard card = handler.ShowKanjiCardCanvas();
        card.FillKanjiCard(Kanji);
    }
}
