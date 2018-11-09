using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Visibility : NetworkBehaviour {
    public bool IsVisible;

    private MeshRenderer meshRenderer;

    public Material visibleMat;
    public Material invisibleMat;

    public List<Material> PlayerColors;
    public List<Material> PlayerInvisColors;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();

        visibleMat = PlayerColors[Random.Range(0, PlayerColors.Count - 1)];
        invisibleMat = PlayerInvisColors[Random.Range(0, PlayerInvisColors.Count - 1)];
    }

    private void Update() {
        if (IsVisible && meshRenderer.sharedMaterial != visibleMat) {
            if (isLocalPlayer)
                meshRenderer.sharedMaterial = visibleMat;
            if (!isLocalPlayer) {
                meshRenderer.sharedMaterial = visibleMat;
                meshRenderer.enabled = true;
            }

            return;
        }

        if (!IsVisible && meshRenderer.sharedMaterial != invisibleMat) {
            if (isLocalPlayer)
                meshRenderer.sharedMaterial = invisibleMat;
            if (!isLocalPlayer) {
                meshRenderer.enabled = false;
                meshRenderer.sharedMaterial = invisibleMat;
            }
        }
    }
}