
#ifndef MY_UNLIT_PASS_INCLUDED
#define MY_UNLIT_PASS_INCLUDED

#include "../ShaderLibrary/Common.hlsl"

float4 UnlitPassVertex(float3 positionOS : POSITION) : SV_POSITION
{
    // return float4(positionOS, 1.0);
    float3 positionWS = TransformObjectToWorld(positionOS.xyz);
    return TransformWorldToHClip(positionWS);
}


float4 UnlitPassFragment() : SV_Target
{
    return 0.0;
}



#endif

