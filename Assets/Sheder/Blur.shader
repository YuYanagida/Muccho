Shader "Custom/Blur"
{
    Properties
    {
     //   _MainTex("Texture", 2D) = "white" {}
        _Blur("Blur", Float) = 10
    }
        SubShader
        {

            Tags{ "Queue" = "Transparent" }

            GrabPass{}// {"_MainTex"}
           

            Pass
            {
                CGPROGRAM

                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"

                struct appdata
                {
                    float4 vertex : POSITION;
                    float2 uv : TEXCOORD0;
                    fixed4 color : COLOR;

                 //   UNITY_VERTEX_INPUT_INSTANCE_ID // ’Ç‰Á

                };

                struct v2f
                {
                    float4 grabPos : TEXCOORD0;
                    float4 pos : SV_POSITION;
                    float4 vertColor : COLOR;

                  //  UNITY_VERTEX_OUTPUT_STEREO // ’Ç‰Á

                };

                v2f vert(appdata v)
                {
                    v2f o;

                  //  UNITY_SETUP_INSTANCE_ID(v);
                  //  UNITY_INITIALIZE_OUTPUT(v2f, o);
                  //  UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o); //’Ç‰Á

                    o.pos = UnityObjectToClipPos(v.vertex);
                    o.grabPos = ComputeGrabScreenPos(o.pos);
                    o.vertColor = v.color;
                    return o;
                }

                sampler2D _GrabTexture;
               // sampler2D _MainTex;
                fixed4 _GrabTexture_TexelSize;

                float _Blur;

               // UNITY_DECLARE_SCREENSPACE_TEXTURE(_GrabTexture);

                half4 frag(v2f i) : SV_Target
                {

                   //     UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i);

                   // fixed4 col = UNITY_SAMPLE_SCREENSPACE_TEXTURE(_GrabTexture, i.uv); //’Ç‰Á


                    float blur = _Blur;
                    blur = max(1, blur);

                    fixed4 col = (0, 0, 0, 0);
                    float weight_total = 0;

                    [loop]
                    for (float x = -blur; x <= blur; x += 1)
                    {
                        float distance_normalized = abs(x / blur);
                        float weight = exp(-0.5 * pow(distance_normalized, 2) * 5.0);
                        weight_total += weight;
                        col += tex2Dproj(_GrabTexture, i.grabPos + float4(x * _GrabTexture_TexelSize.x, 0, 0, 0)) * weight;
                    }

                    col /= weight_total;
                    return col;
                }
                ENDCG
            }
            GrabPass
            {
            }

            Pass
            {
                CGPROGRAM

                #pragma vertex vert
                #pragma fragment frag
                #include "UnityCG.cginc"

                struct appdata
                {
                    float4 vertex : POSITION;
                    float2 uv : TEXCOORD0;
                    fixed4 color : COLOR;

                 //   UNITY_VERTEX_INPUT_INSTANCE_ID // ’Ç‰Á

                };

                struct v2f
                {
                    float4 grabPos : TEXCOORD0;
                    float4 pos : SV_POSITION;
                    float4 vertColor : COLOR;

                 //   UNITY_VERTEX_OUTPUT_STEREO // ’Ç‰Á

                };

                v2f vert(appdata v)
                {
                    v2f o;

                 //   UNITY_SETUP_INSTANCE_ID(v);
                 //   UNITY_INITIALIZE_OUTPUT(v2f, o);
                 //   UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o); //’Ç‰Á

                    o.pos = UnityObjectToClipPos(v.vertex);
                    o.grabPos = ComputeGrabScreenPos(o.pos);
                    o.vertColor = v.color;
                    return o;
                }

                sampler2D _GrabTexture;
                fixed4 _GrabTexture_TexelSize;

                float _Blur;

                half4 frag(v2f i) : SV_Target
                {

                  //  UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i);

                   // fixed4 col = UNITY_SAMPLE_SCREENSPACE_TEXTURE(_MainTex, i.uv); //’Ç‰Á

                    float blur = _Blur;
                    blur = max(1, blur);

                    fixed4 col = (0, 0, 0, 0);
                    float weight_total = 0;

                    [loop]
                    for (float y = -blur; y <= blur; y += 1)
                    {
                        float distance_normalized = abs(y / blur);
                        float weight = exp(-0.5 * pow(distance_normalized, 2) * 5.0);
                        weight_total += weight;
                        col += tex2Dproj(_GrabTexture, i.grabPos + float4(0, y * _GrabTexture_TexelSize.y, 0, 0)) * weight;
                    }

                    col /= weight_total;
                    return col;
                }
                ENDCG
            }

        }
}