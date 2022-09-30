using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construction : MonoBehaviour
{
    public GameObject cubepref;
    GameObject bruh;
    // Start is called before the first frame update
    void Start()
    {
        bruh = Instantiate(cubepref, gameObject.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        bruh.transform.Rotate(0,.09f,0.09f);
    }
}
