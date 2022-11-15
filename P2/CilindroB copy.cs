using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroB : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody c;
    private GameObject cubo;
    void Start()
    {
        c = GetComponent<Rigidbody>();
        cubo = GameObject.Find("Cube");
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 PosCubo = cubo.transform.position;
        Vector3 PosC = c.transform.position;
        Vector3 mov = Vector3.Normalize(PosC-PosCubo);
        float dist = Vector3.Distance(PosC,PosCubo); 
        if (dist <= 5)
        {
            c.MovePosition(transform.position + mov*0.5f);
        }
    }
}
