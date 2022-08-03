using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiSpawner : MonoBehaviour
{
    [SerializeField] private GameObject kanjiPrefab;
    [SerializeField] private Vector3 spawnPosition;
  
    public KanjiDisplay SpawnKanjiDisplay()
    {
        float x = Random.Range(-spawnPosition.x, spawnPosition.x);
        GameObject kanjiObject =  Instantiate(kanjiPrefab, new Vector3(x, spawnPosition.y, spawnPosition.z), Quaternion.identity);
        KanjiDisplay kanjiDisplay = kanjiObject.GetComponent<KanjiDisplay>();

        return kanjiDisplay;
    }
}
