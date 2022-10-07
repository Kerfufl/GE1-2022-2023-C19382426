using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatE : MonoBehaviour
{

    public GameObject piv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(piv.transform.position, Vector3.left,.5f);
    }
}
