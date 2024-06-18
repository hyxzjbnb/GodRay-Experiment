Shader "Unlit/VolumetricLightTutorial"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Pass
        {
            //光线步进采样 计算体积光
            HLSLPROGRAM
            #include "VolumetricLightTutorial.hlsl" 
            #pragma vertex vert
            #pragma fragment frag
            ENDHLSL 
        }        
        Pass
        {
            HLSLPROGRAM
            #include "KawaseBlur.hlsl" 
            #pragma vertex vertex
            #pragma fragment fragment
            ENDHLSL 
        }
        Pass
        {
            HLSLPROGRAM
            #include "VolumetricLightTutorial.hlsl" 
            #pragma vertex vert
            #pragma fragment blendFrag
            ENDHLSL 
        }
    }
}