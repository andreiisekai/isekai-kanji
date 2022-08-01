using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] private SpawnKanji spawnKanji;
    float _time;
    // Start is called before the first frame update
    void Start()
    {
        _time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnKanji();
    }

    void SpawnKanji()
    {
        _time += Time.deltaTime;
        while (_time >= spawnKanji.SpawnSpeed)
        {
            GameObject kanjiPrefab = spawnKanji.SpawnAPrefab();
            KanjiHolder kanjiHolder = kanjiPrefab.GetComponent<KanjiHolder>();
            Debug.Log("Spawned - "+ kanjiHolder.KanjiChar.Symbol);
            _time -= spawnKanji.SpawnSpeed;
        }
    }
}
