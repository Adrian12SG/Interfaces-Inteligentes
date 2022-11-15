using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroA : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody c;
    private GameObject cubo;
    void Start()
    {
        c = GetComponent<Rigidbody>();
        cubo = GameObject.Find("Cube");
        Vector3 movimiento = new Vector3(1,0,1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 PosCubo = cubo.transform.position;
            Vector3 PosC = c.transform.position;
            Vector3 mov = Vector3.Normalize(PosC-PosCubo); 
            c.MovePosition(transform.position + mov*0.5f);
        }
    }
}
