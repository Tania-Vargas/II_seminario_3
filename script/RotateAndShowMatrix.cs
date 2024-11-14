using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndShowMatrix : MonoBehaviour {
  public Transform objeto;
  public Vector3 rotation;
  void Start() {
    objeto.transform.Rotate(rotation);
    Matrix4x4 modelMatrix = objeto.transform.localToWorldMatrix;
    Debug.Log("Matriz de transformación al sistema de referencia mundial después de la rotación:\n" + modelMatrix.ToString());
  }
}
