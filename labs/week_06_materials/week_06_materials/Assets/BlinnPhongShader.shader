Shader "Unlit/BlinnPhongShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
                float3 normal : NORMAL0;
                float3 wsPos : TEXCOORD1;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.normal = mul(unity_ObjectToWorld, v.normal);
                o.wsPos = mul(unity_ObjectToWorld, float4(v.normal, 0.0)).xyz;
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float3 N = normalize(i.normal); 
                float3 L = normalize(_WorldSpaceLightPos0);
                float3 V = normalize(_WorldSpaceCameraPos.xyz - i.wsPos);
                float3 H = normalize(V + L);
                float diff = dot(N,L);
         
                float spec = pow((max(dot(N, H), 0)), 200);

                float remapped = (diff * 0.5) + 0.5;
                float3 gooch = lerp(float3(0, 0, 1), float3(1,1,0), remapped);
                float3 cell = tex2D(_MainTex, float2(remapped, 0.5)).xyz;
                fixed4 col = 0;
                col.xyz = spec + cell;

                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
