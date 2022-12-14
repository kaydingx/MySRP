using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MyRenderPipeline : RenderPipeline
{
    private CameraRenderer renderer = new CameraRenderer();

    public MyRenderPipeline()
    {
        GraphicsSettings.useScriptableRenderPipelineBatching = true;
    }
    
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        foreach (Camera camera in cameras)
        {
            renderer.Render(context, camera);
        }
    }
}
