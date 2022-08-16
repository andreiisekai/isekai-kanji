using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "KanjiSettings", fileName = "KanjiSettings")]
public class KanjiSettings : ScriptableObject
{
    [SerializeField] bool jlptn5Toggle, hiraganaToggle, katakanaToggle, romajiToggle, challengeModeToggle;
    [SerializeField] float volume;
    public bool Jlpnt5Toggle { get => jlptn5Toggle; set => jlptn5Toggle = value; }
    public bool HiraganaToggle { get => hiraganaToggle; set => hiraganaToggle = value; }
    public bool KatakanaToggle { get => katakanaToggle; set => katakanaToggle = value; }
    public bool RomajiToggle { get => romajiToggle; set => romajiToggle = value; }
    public bool ChallengeModeToggle { get => challengeModeToggle; set => challengeModeToggle = value; }
    public float Volume { get => volume; set => volume = value; }
}
