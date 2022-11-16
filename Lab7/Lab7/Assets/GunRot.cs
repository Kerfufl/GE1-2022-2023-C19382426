using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRot : MonoBehaviour
{
    private Collider col; 
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnTriggerEnter(Collision other) {
    //     Debug.Log("Bruh");
    // }
}
