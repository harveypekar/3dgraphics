using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexGen : MonoBehaviour
{
    // Start is called before the first frame update
    Texture2D texture;
    void Start()
    {
        int dimension = 2048;
        Vector2Int dimensions = new Vector2Int(dimension, dimension);
        Vector2 halfPixel = new Vector2(0.5f, 0.5f) / dimensions;

        texture = new Texture2D(dimensions.x, dimensions.y, 
            TextureFormat.ARGB32, false);
        texture.filterMode = FilterMode.Point;

        for (int y = 0; y < dimensions.y; ++y)
        {
            for (int x = 0; x < dimensions.x; ++x)
            {
                Vector2 texcoord = new Vector2(x, y) / dimensions + 
                    halfPixel;

                texture.SetPixel(x, y, new Color(texcoord.x, texcoord.y, 0.0f));
            }
        }
        texture.Apply();
       
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
