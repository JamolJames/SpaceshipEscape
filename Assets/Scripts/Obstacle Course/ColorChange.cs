using UnityEngine;

public class ColorChange : MonoBehaviour
{
    MeshRenderer meshRenderer; // Cache the MeshRenderer component
    Color defaultColor;

void Start()
{
    meshRenderer = GetComponent<MeshRenderer>(); // Store the MeshRenderer component
    defaultColor = meshRenderer.material.color; // Store the default color
    
}

void Update()
    {
        ToggleColor();
    }

private void ToggleColor()
{
    if (Input.GetKey(KeyCode.A))
    {
        meshRenderer.material.color = Color.red;
    }
    else
    {
        meshRenderer.material.color = defaultColor;

    }
}
}
