using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construction : MonoBehaviour
{
    public GameObject cubepref;
    public int no_obj = 6;
    public int rings = 4;
    public float b_rad = 2f;
    public float rad;

    // Start is called before the first frame update
    void Start()
    {
        rad = b_rad;
        for (int j =0; j < rings; j++)
        {
            Circ_Inst();
            no_obj += 6;
            rad += b_rad;
        }
        
        //Instantiate(cubepref, gameObject.transform.position,Quaternion.identity);
    }

    void Circ_Inst()
    {
        for (int i = 0; i < no_obj; i++)
        {
           float angle = i * Mathf.PI * 2 / no_obj;
           float x = Mathf.Cos(angle) * rad;
           float z = Mathf.Sin(angle) * rad;
           Vector3 pos = transform.position + new Vector3(x, 0, z);
           float angleDegrees = -angle*Mathf.Rad2Deg;
           Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
           Instantiate(cubepref, pos, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
