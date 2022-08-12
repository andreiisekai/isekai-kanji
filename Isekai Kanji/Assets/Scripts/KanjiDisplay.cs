using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KanjiDisplay : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private KanjiGenerator kanjiGenerator;
    [SerializeField] private KanjiSettings settings;
    [SerializeField] private KanaParser kanaParser;
    [SerializeField] private TextMeshPro symbol;
    [SerializeField] private TextMeshPro reading;
    [SerializeField] private float fallSpeed = 5.0f;
    private int typeIndex;
    private Kanji kanji;
    public Kanji Kanji { get => kanji; set => kanji = value; }
    private string hintText;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        Kanji = kanjiGenerator.GetRandomKanji(settings);
        hintText = kanaParser.Parse(Kanji.Onyomi[0]);
        Debug.Log(Kanji.Onyomi[0]+" = "+ hintText);
        SetText(Kanji.Symbol, hintText);
    }
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    public void SetText(string kanjiSymbol, string kanjiReading)
    {
        symbol.text = kanjiSymbol;
        if (settings.RomajiToggle)
        {
            reading.text = kanjiReading;
        }
        else
        {
            reading.text = "";
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        gameManager.RemoveKanjiAndLives(this);
    }

    public bool KanjiTyped => typeIndex >= hintText.Length;

    public char GetNextLetter()
    {
        string kanjiString = hintText;
        Debug.Log("Meaning = " + kanjiString + ", typeIndex = " + typeIndex);
        return kanjiString[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        RemoveLetter();
    }

    public void RemoveLetter()
    {
        if (symbol.text == Kanji.Symbol && KanjiTyped)
        {
            symbol.text = symbol.text.Remove(0, 1);
        }
        else if (symbol.text != Kanji.Symbol && !settings.RomajiToggle)
        {
            symbol.text = symbol.text.Remove(0, 1);
        }else
        {
            reading.text = reading.text.Remove(0, 1);
        }
        symbol.color = Color.cyan;
        reading.color = Color.cyan;
    }

}
