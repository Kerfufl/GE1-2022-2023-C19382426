using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatE : MonoBehaviour
{
    public float ang = .5f;
    public float theta = 0f;
    public GameObject piv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.RotateAround(piv.transform.position, Vector3.left,ang);
        // } else if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.RotateAround(piv.transform.position, Vector3.left,-ang);
        // }
        
        transform.RotateAround(piv.transform.position, Vector3.left,Mathf.Sin(theta));
        theta+=Time.deltaTime;
        //Struggling with getting the sine wave working
        float an = Mathf.Sin(theta)*(.5f);
        Debug.Log(an.ToString() + "\r");
        
    }
}
