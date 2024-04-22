using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TexGen : MonoBehaviour
{
    // Start is called before the first frame update
    Texture2D texture;
    void Start()
    {
        /*
        int pixelDimension = 2048;
        Vector2Int pixelDimensions = new Vector2Int(pixelDimension, pixelDimension);
        Vector2 halfPixel = new Vector2(0.5f, 0.5f) / pixelDimension;

        texture = new Texture2D(pixelDimension.x, pixelDimension.y,
            TextureFormat.ARGB32, false);
        texture.filterMode = FilterMode.Point;

        for (int y = 0; y < pixelDimension.y; ++y)
        {
            for (int x = 0; x < pixelDimension.x; ++x)
            {
                Vector2 texcoord = new Vector2(x, y) / pixelDimension +
                    halfPixel;

                Vector2 basecoord = new Vector2(texcoord.x, texcoord.y) * 5;
                float perlin = Mathf.PerlinNoise(basecoord.x, basecoord.y);
                texture.SetPixel(x, y, new Color(perlin, perlin, perlin));
            }
        }
        texture.Apply();
        */
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = texture;

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        int dimension = 256;
        Vector3 objectMin = new Vector3(-5.5f, 0.0f, -5.5f);
        Vector3 objectMax = new Vector3(5.5f, 0.0f, 5.5f);
        Vector3 objectBounds = objectMax - objectMin;

        int vertexCount = (dimension + 1) * (dimension + 1);
        Vector3[] vertices = new Vector3[vertexCount];

        Vector3 objectStep = objectBounds / dimension;
        int vertIndex = 0;
        for (int y = 0; y <= dimension; ++y)
        {
            for (int x = 0; x <= dimension; ++x)
            {



                float height = 0;
                float initialOffset = 3.0f;
                float initialScale = 1.0f;
                int iterations = 4;
                float a = 0.4f;
                float b = 0.7f;

                float offset = initialOffset;
                float scale = initialScale;

                Vector2 uv = new Vector2(x, y);
                uv /= dimension;

                for (int i = 0; i < iterations; ++i)
                {
                    uv *= scale;
                    scale /= b;

                    float perlin = Mathf.PerlinNoise(uv.x, uv.y) * offset;
                    offset *= a;

                    height += perlin;
                };

                Vector3 pos = new Vector3(
                    objectMin.x + objectStep.x * x,
                    height,
                    objectMin.z + objectStep.z * y
                    );
                vertices[vertIndex++] = pos;
            }
        }

        // patches
        int[] newTriangles = new int[dimension * dimension * 6];
        int index = 0;

        for (int y = 0; y < dimension; ++y)
        {
            for (int x = 0; x < dimension; ++x)
            {
                newTriangles[index++] = x + 0 + y * (dimension + 1);
                newTriangles[index++] = x + (y + 1) * (dimension + 1);
                newTriangles[index++] = x + 1 + y * (dimension + 1);

                newTriangles[index++] = x + (y + 1) * (dimension + 1);
                newTriangles[index++] = x + 1 + (y+1)* (dimension + 1);
                newTriangles[index++] = x + 1 + y * (dimension + 1);
            }
        };


        Vector3[] normals = new Vector3[vertices.Length];
        for (int i = 0; i < normals.Length; ++i)
            normals[i] = new Vector3(0.0f, 1.0f, 0.0f);

        for (int y = 1; y < dimension; ++y)
        {
            for (int x = 1; x < dimension; ++x)
            {
                Vector3 center = vertices[x + y * (dimension+1)];
                Vector3 left = vertices[(x - 1) + (y * dimension+1)];
                Vector3 bottom = vertices[x + (y - 1) * (dimension+1)];

                Vector3 cross = Vector3.Cross(
                    left - center,
                    bottom - center
                    );
                Vector3 normal = cross.normalized; 
                if (normal.y < 0)
                {
                    normal.y = -normal.y;
                }
                normals[x + y * dimension] = normal;
               
            }
        }

        Vector2[] uvs = new Vector2[vertices.Length];
        Vector2 uvStep = new Vector2(1.0f / dimension, 1.0f / dimension);
        for (int y = 0; y <= dimension; ++y)
        {
            for (int x = 0; x <= dimension; ++x)
            {
                Vector2 uv = uvStep * new Vector2(x, y);
                uvs[x + y * (1+dimension)] = uv;
            }
        }

        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = newTriangles;
        mesh.normals = normals;
        /*

        Vector3[] newVertices = new Vector3[]
        {
            new Vector3(0.0f,0.0f,0.0f),
            new Vector3(0.0f, 0.0f, 1.0f),
            new Vector3(1.0f, 0.0f, 0.0f),
            new Vector3(1.0f, 0.0f, 1.0f)
        };

        Vector2[] newUV = new Vector2[]
        {
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f),
            new Vector2(0.0f, 0.0f)
        };

        Vector3[] normals = new Vector3[3];

        for (int i = 0; i < normals.Length; ++i)
        {
            normals[i] = new Vector3(0.0f, 1.0f, 0.0f);
        }

        int[] newTriangles = new int[] { 
            0, 1, 2,
            3, 2, 1
        };
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
