using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarPersonaje : MonoBehaviour
{

    private Rigidbody monstruo;
    public float velocidad;
    public float rotacion;
    
    // Start is called before the first frame update
    void Start()
    {
        monstruo = GetComponent<Rigidbody>();
        velocidad = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 d = new Vector3(hor,0,ver);
        Quaternion q = Quaternion.LookRotation(d);
        monstruo.MovePosition(transform.position +d*velocidad*Time.deltaTime);
        monstruo.MoveRotation(q);
        if (Input.GetButtonDown ("Jump")){

            Vector3 tp = new Vector3(hor*15f,0,ver*15f);
            monstruo.MovePosition(transform.position + tp);

        }

        
    }
}
