Shader "Custom/CheckersShader3D"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0

        _Space ("Space (object = 0, world = 1, view = 2", Integer) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows vertex:vert 

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldPos;
            float3 screenPos;
            float3 localPos;
        };


        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        int _Space;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        void vert (inout appdata_full v, out Input o) {
            UNITY_INITIALIZE_OUTPUT(Input,o);
            o.localPos = v.vertex;
        }
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            int2 checkCoord;
            
            int3 checkPos;
            
            switch(_Space)
            {
            case 0:
                checkPos = IN.worldPos;
                break;
            case 1:
                checkPos = IN.screenPos;
                break;
            case 2:
                checkPos = IN.localPos * 5;
                break;
            }
            bool check = (checkPos.x + checkPos.y + checkPos.z) % 2 == 0;

            fixed4 c = 0;
            if (check)
                c = 1;
            o.Albedo = c.rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
