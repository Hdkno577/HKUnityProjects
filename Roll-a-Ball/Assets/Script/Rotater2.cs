using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater2 : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(45, 90, 45) * Time.deltaTime);
    }
}
