using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKanji : MonoBehaviour
{
    [SerializeField] private GameObject kanjiPrefab;
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private float spawnSpeed = 1f;

    public float SpawnSpeed { get => spawnSpeed; }

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("OnSpawnAPrefab", 1f, spawnSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SpawnAPrefab()
    {
        float x = Random.Range(-spawnPosition.x, spawnPosition.x);
        return Instantiate(kanjiPrefab, new Vector3(x, spawnPosition.y, spawnPosition.z), Quaternion.identity);
    }
}
