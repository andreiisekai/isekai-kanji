using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanjiTimer : MonoBehaviour
{
    public GameManager gameManager;
    public float delay = 1.5f;
    private float nextKanjiTime = 0f;

    void Update()
    {
        if (Time.time >= nextKanjiTime)
        {
            gameManager.AddKanji();
            nextKanjiTime = Time.time + delay;
            delay *= .99f;
        }
    }
}
