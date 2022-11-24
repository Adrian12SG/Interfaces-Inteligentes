using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarPersonaje: MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody cubo;
    private float velocidad;
    private float rotacion;
    private int puntuacion;

    void Start()
    {
        cubo = GetComponent<Rigidbody>();
        velocidad = 10f;
        puntuacion = 0;
    }

    // Update is called once per frame

    void FixedUpdate(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(hor,0,ver);
        //Vector3 v2 = new Vector3(0,hor,0);
        Quaternion q = Quaternion.LookRotation(v);
        //Quaternion q = Quaternion.Euler(v2*rotacion*Time.deltaTime);
        cubo.MovePosition(transform.position + v*velocidad*Time.deltaTime);
        cubo.MoveRotation(q);


    }

    public void AumentarPuntuacion(){
        puntuacion +=1;
        Debug.Log(puntuacion);
    }
}
