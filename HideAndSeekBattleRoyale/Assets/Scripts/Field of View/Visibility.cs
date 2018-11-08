using UnityEngine;

public class Visibility : MonoBehaviour {
    public bool IsVisible;

    private MeshRenderer meshRenderer;

    public Material visibleMat;
    public Material invisibleMat;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (IsVisible && meshRenderer.sharedMaterial != visibleMat) {
            meshRenderer.sharedMaterial = visibleMat;
            return;
        }

        if (!IsVisible && meshRenderer.sharedMaterial != invisibleMat) {
            meshRenderer.sharedMaterial = invisibleMat;
        }
    }
}