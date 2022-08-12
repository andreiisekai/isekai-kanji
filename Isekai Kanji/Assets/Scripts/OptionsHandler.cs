using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsHandler : MonoBehaviour
{
    [SerializeField] KanjiSettings settings;
    [SerializeField] Toggle jlptn5Toggle, hiraganaToggle, katakanaToggle, romajiToggle;
    [SerializeField] Button start;
    // Start is called before the first frame update
    void Start()
    {
        jlptn5Toggle.isOn = settings.Jlpnt5Toggle;
        hiraganaToggle.isOn = settings.HiraganaToggle;
        katakanaToggle.isOn = settings.KatakanaToggle;
        romajiToggle.isOn = settings.RomajiToggle;
        ValidateToggle();
    }

    public void ValidateToggle()
    {
        if (!settings.Jlpnt5Toggle && !settings.HiraganaToggle && !settings.KatakanaToggle)
        {
            start.interactable = false;
        }
        else
        {
            start.interactable = true;
        }
    }

   
}
