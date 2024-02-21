using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // initialize with all components
        Vector3 v1 = new (2, 1, 0);
        // shorthand for (0, 0, 0)
        Vector3 v2 = Vector3.zero;
        // shorthand for (1, 0, 0). All 6 directions exist
        Vector3 v3 = Vector3.right;


        Transform transform = gameObject.transform;
        transform.position = new Vector3(1, 2, 0);
        transform.Translate(new Vector3(3, 0, 0));
        transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);


        Matrix4x4.Scale(new Vector3(2.0f, 2.0f, 2.0f));
        Debug.Log(v1 + v2 + v3);

        GameObject bunnyGameObject = gameObject;
        GameObject cameraGameObject = gameObject;
        Vector3 position = bunnyGameObject.transform.position; // in WorldSpace
        cameraGameObject.transform.TransformPoint(position); // in CameraSpace
                                                             // Matrix4x4 worldToView = bunnyGameObject.transf
                // bunnyGameObject.transform.Rotate(UnityEngine.Space.Self);
        Matrix4x4 worldToView = cameraGameObject.transform.worldToLocalMatrix;
        Matrix4x4 bunnyToWorld = bunnyGameObject.transform.localToWorldMatrix;
        Matrix4x4 bunnyToView = bunnyToWorld * worldToView;

        Vector3 a = new Vector3(1.0f, 2.0f, 0.0f);
        Vector3 b = new Vector3(2.0f, 1.0f, 0.0f);
        Vector3 c = a + b;

        // rotate around up
        Quaternion rotation = Quaternion.AngleAxis(30, Vector3.up);
    }
}
