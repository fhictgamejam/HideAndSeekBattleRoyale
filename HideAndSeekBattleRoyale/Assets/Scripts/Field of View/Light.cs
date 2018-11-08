using UnityEngine;

public class Light : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Enter");
        if (other.gameObject.GetComponent<Visibility>() != null)
            other.gameObject.GetComponent<Visibility>().IsVisible = true;
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Exit");
        if (other.gameObject.GetComponent<Visibility>() != null)
            other.gameObject.GetComponent<Visibility>().IsVisible = false;
    }

    private void Start() {
        DestroyImmediate(GetComponent<MeshCollider>());
        MeshCollider coll = gameObject.AddComponent<MeshCollider>();
        coll.sharedMesh = GetComponent<MeshFilter>().mesh;
        coll.convex = true;
        coll.isTrigger = true;
    }
}