using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] KanjiSettings settings;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().volume = settings.Volume;
    }
}
