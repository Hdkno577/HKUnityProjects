using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 1, 0);
        transform.localScale = Vector3.one * 3.0f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 5.0f, 10.0f, 0.9f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 5.0f, 2.0f);
    }
}
