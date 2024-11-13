using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraTrasRot : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform cameraTransform;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        cameraTransform.Translate(2f, 2f, 2f); // Traslada la cámara 2 metros en cada eje.
        cameraTransform.Rotate(0f, 30f, 0f);   // Rota la cámara 30° alrededor del eje Y.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
