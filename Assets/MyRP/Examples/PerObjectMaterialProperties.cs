using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
public class PerObjectMaterialProperties : MonoBehaviour
{
    private static MaterialPropertyBlock block;
    
    private static int baseColorId = Shader.PropertyToID("_BaseColor");

    [SerializeField] private Color baseColor = Color.white;

    private void OnValidate()
    {
        if (block == null)
        {
            block = new MaterialPropertyBlock();
        }
        block.SetColor(baseColorId, baseColor);
        GetComponent<Renderer>().SetPropertyBlock(block);
    }

    private void Awake()
    {
        OnValidate();
    }
}
