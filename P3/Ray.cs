using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 forward = new Vector3(10,10,10);
        Debug.DrawRay(transform.position, transform.forward*10, Color.green);
    }
}
