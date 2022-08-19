using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionManager : MonoBehaviour
{
    [SerializeField] List<Material> materials;
    [SerializeField] ScoreManager scoreManager;
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (scoreManager.Lives > 0 && meshRenderer.material != materials[scoreManager.Lives -1 ])
        {
            meshRenderer.material = materials[scoreManager.Lives - 1];
        }
    }
}
