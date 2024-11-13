using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraRotTras : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform cameraTransform;  // Referencia al componente Transform de la cámara.
    void Start()
    {
        cameraTransform = Camera.main.transform;  // Obtiene el componente Transform de la cámara principal.
        cameraTransform.Rotate(0f, 30f, 0f);   // Rota la cámara 30° alrededor del eje Y.
        cameraTransform.Translate(2f, 2f, 2f); // Traslada la cámara 2 metros en cada eje.
    }

}
