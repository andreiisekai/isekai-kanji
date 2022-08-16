using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsHandler : MonoBehaviour
{
    [SerializeField] KanjiSettings settings;
    [SerializeField] Toggle jlptn5Toggle, hiraganaToggle, katakanaToggle, romajiToggle, challengeModeToggle;
    [SerializeField] Button start;
    [SerializeField] Scrollbar volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        jlptn5Toggle.isOn = settings.Jlpnt5Toggle;
        hiraganaToggle.isOn = settings.HiraganaToggle;
        katakanaToggle.isOn = settings.KatakanaToggle;
        romajiToggle.isOn = settings.RomajiToggle;
        challengeModeToggle.isOn = settings.ChallengeModeToggle;
        volumeSlider.value = settings.Volume;
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
