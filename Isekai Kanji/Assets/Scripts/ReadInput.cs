using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    public TMP_InputField mainInputField;
    private string inputText;
    // Start is called before the first frame update
    void Start()
    {
        mainInputField.onEndEdit.AddListener(delegate { ReadTMPInput(mainInputField); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadTMPInput(TMP_InputField mainInput)
    {
        inputText = mainInput.text;

        Debug.Log(inputText);
    }
}
