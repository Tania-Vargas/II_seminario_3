using UnityEngine;

public class MatrixProjection : MonoBehaviour
{
  public Camera mainCamera;
  void Start() {
    Matrix4x4 projectionMatrix = mainCamera.projectionMatrix;
    Debug.Log("Matriz de proyección:\n" + projectionMatrix.ToString());
  }
}
