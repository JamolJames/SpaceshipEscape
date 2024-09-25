using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    MeshRenderer renderer;
    Color defaultColor;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        Color defaultColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        // float x = Input.GetAxis("Horizontal");
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Left Mouse Clicked");   
            renderer.material.color = Color.red;
        }
        else
        {
            renderer.material.color = defaultColor;
        }
        
        // GetMousePos();
    }

    // void CickeButton()
    // {
    //     if (Input.GetKeyDown(KeyCode.left))
    // }

    // void GetMousePos()
    // {
    //     float x = Input.mousePosition.x;
    //     float y = Input.mousePosition.y;
    //     Debug.Log($"x axis: {x}, y axis: {y}");
    // }

}
