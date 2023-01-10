using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelScript : MonoBehaviour
{
    public GameObject gauge;
    // Start is called before the first frame update
    void Start()
    {
        gauge.transform.localScale -= new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
