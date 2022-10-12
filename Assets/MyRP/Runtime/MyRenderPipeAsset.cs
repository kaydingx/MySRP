using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[CreateAssetMenu(menuName="Rendering/CreateMyRP")]
public class MyRenderPipeAsset : RenderPipelineAsset
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override RenderPipeline CreatePipeline()
    {
        return new MyRenderPipeline();
    }
}
