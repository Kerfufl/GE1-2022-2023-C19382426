using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateMe : MonoBehaviour
{
    // Start is called before the first frame update
    public float zrot;
    public float yrot;
    void Start()
    {
        yrot = .2f;
        zrot = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0f,yrot,zrot);
    }
}