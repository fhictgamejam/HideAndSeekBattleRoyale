using UnityEngine;
using UnityEngine.Networking;

public class Visibility : NetworkBehaviour {
    public bool IsVisible;

    private MeshRenderer meshRenderer;

    public Material visibleMat;
    public Material invisibleMat;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (IsVisible && meshRenderer.sharedMaterial != visibleMat) {
            if (isLocalPlayer)
                meshRenderer.sharedMaterial = visibleMat;
            if (!isLocalPlayer)
                meshRenderer.enabled = true;
            return;
        }

        if (!IsVisible && meshRenderer.sharedMaterial != invisibleMat) {
            if (isLocalPlayer)
                meshRenderer.sharedMaterial = invisibleMat;
            if (!isLocalPlayer)
                meshRenderer.enabled = false;
        }
    }
}