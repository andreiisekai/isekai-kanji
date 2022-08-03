using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            gameManager.TypeLetter(letter);
            Debug.Log(letter);
        }
    }
}
