using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelpDisplay : MonoBehaviour
{
    [SerializeField] private GameObject kanjiElement;
    [SerializeField] private JLPT jlptn5;
    [SerializeField] private KanaSystem hiragana, katakana;
    [SerializeField] private KanaParser kanaParser;
    private Vector3 helpNextPosition;

    private void Start()
    {

    }

    public void PopulateWithJLPTN5()
    {
        PopulateWithJLPT(jlptn5);
    }

    public void PopulateWithHiragana()
    {
        PopulateWithKana(hiragana);
    }

    public void PopulateWithKatakana()
    {
        PopulateWithKana(katakana);
    }

    private void PopulateWithJLPT(JLPT jlpt)
    {
        DestroyChildren();
        helpNextPosition = Vector3.zero;
        foreach (var kanji in jlpt.kanji)
        {
            InstantiateKanjiElement(kanji, helpNextPosition);
            helpNextPosition.x += 150f;
        }
    }
    private void PopulateWithKana(KanaSystem kanaSystem)
    {
        DestroyChildren();
        helpNextPosition = Vector3.zero;
        foreach (var kana in kanaSystem.kana)
        {
            InstantiateKanjiElement(new Kanji(kana), helpNextPosition);
            helpNextPosition.x += 150f;
        }
    }

    private void InstantiateKanjiElement(Kanji kanji, Vector3 kanjiPosition)
    {
        GameObject kanjiObject = Instantiate(kanjiElement, kanjiPosition, Quaternion.identity);
        kanjiObject.transform.SetParent(gameObject.transform, false);
        string kanjiReading = kanaParser.Parse(kanji.Onyomi[0]);
        SetText(kanjiObject, kanji.Symbol, kanjiReading);
    }

    private void SetText(GameObject kanjiObject, string kanjiSymbol, string kanjiReading)
    {
        kanjiObject.GetComponentInChildrenByName<TextMeshProUGUI>("Symbol").text = kanjiSymbol;
        kanjiObject.GetComponentInChildrenByName<TextMeshProUGUI>("Reading").text = kanjiReading;
    }

    private void DestroyChildren()
    {
        foreach (Transform child in gameObject.transform)
        {
            Destroy(child.gameObject);
        }
    }
}