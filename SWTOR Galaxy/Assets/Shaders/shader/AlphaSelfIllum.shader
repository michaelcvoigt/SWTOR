Shader "My Shaders/AlphaSelfIllum" {
    Properties 
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("SelfIllum Color (RGB) Alpha (A)", 2D) = "white"
    }
    
    Category 
    {
       Lighting On
       ZWrite Off
       ZTest Off
       Cull Back
       Blend SrcAlpha OneMinusSrcAlpha
      	Alphatest Greater 0
      	
       SubShader 
       {
       	
            Material {
               Emission [_Color]
            }
         
            Pass {
                SetTexture [_MainTex] 
                {
                      Combine Texture * Primary, Texture * Primary
                }
               
                
            }
                   
        }        
    }
}