using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class CharacterGUI : MonoBehaviour
{

    private bool isRotation = false;
    private int selectedAnimation = 0;
    private string[] animationStrings = { "None", "Running", "JumpingJacks" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRotation)
        {
            transform.rotation = Quaternion.identity;
        }
        else
        {
            transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * 25.0f);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100),"Character");
        GUI.Label(new Rect(25, 25, 100, 30), "Animation");
        isRotation = GUI.Toggle(new Rect(25, 50, 100, 30), isRotation, "Rotate");
        selectedAnimation = GUI.Toolbar(new Rect(100, 0, 350, 30), selectedAnimation, animationStrings);
    }
}
