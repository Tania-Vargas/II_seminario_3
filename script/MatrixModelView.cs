using UnityEngine;

public class MatrixModelView : MonoBehaviour {
  public Camera maincamera;
  public Transform objeto; 

  void Start() {
    Matrix4x4 viewMatrix = maincamera.worldToCameraMatrix;
    Debug.Log("Matriz de vista:\n" + viewMatrix.ToString());
    if (objeto != null) {
      Matrix4x4 modelMatrix = objeto.localToWorldMatrix;
      Debug.Log("Matriz de modelo:\n" + modelMatrix.ToString());
    }
  }
}
