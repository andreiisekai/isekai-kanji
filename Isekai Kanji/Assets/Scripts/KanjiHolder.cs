using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KanjiHolder : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro textMeshPro;
    [SerializeField]
    private float speed = 8.0f;
    [SerializeField]
    private JLPT jlpt1;
    Kanji kanjiChar;

    public Kanji KanjiChar { get => kanjiChar; private set => kanjiChar = value;}

    // Start is called before the first frame update
    private void Awake()
    {
        KanjiChar = GetRandomKanji();
    }
    void Start()
    {
        textMeshPro.text = KanjiChar.Symbol;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
    }

    private Kanji GetRandomKanji()
    {
        int orderNumber = Random.Range(0, jlpt1.kanji.Length);
        return jlpt1.kanji[orderNumber];
    }

    private void OnTriggerEnter(Collider other)
    {
        RemoveKanji();
    }

    private void RemoveKanji()
    {
        Debug.Log("->" + string.Join(",",KanjiChar.Onyomi));
        Destroy(gameObject);
    }
}
