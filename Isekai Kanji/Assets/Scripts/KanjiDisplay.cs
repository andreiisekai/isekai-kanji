using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KanjiDisplay : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private KanjiGenerator kanjiGenerator;
    [SerializeField] private KanaParser kanaParser;
    [SerializeField] private TextMeshPro textMeshPro;
    [SerializeField] private float fallSpeed = 5.0f;
    private int typeIndex;
    private Kanji kanji;
    public Kanji Kanji { get => kanji; set => kanji = value; }
    private string displayText;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        Kanji = kanjiGenerator.GetRandomKanji();
        displayText = kanaParser.Parse(Kanji.Onyomi[0]);
        SetText(displayText);
    }
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    public void SetText(string word)
    {
        textMeshPro.text = word;
    }


    private void OnTriggerEnter(Collider other)
    {
        gameManager.RemoveKanjiFromList(this);
    }

    public bool KanjiTyped()
    {
        bool kanjiTyped = (typeIndex >= displayText.Length);
        if (kanjiTyped)
        {
            gameManager.RemoveKanjiFromList(this);
        }
        return kanjiTyped;
    }

    public char GetNextLetter()
    {
        string kanjiString = displayText;
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
        textMeshPro.text = textMeshPro.text.Remove(0, 1);
        textMeshPro.color = Color.cyan;
    }

}
