using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje: MonoBehaviour
{
    // Start is called before the first frame update
    private int puntuacion;

    void Start()
    {
        puntuacion = 0;
    }

    // Update is called once per frame

    void Update(){

    }

    public void AumentarPuntuacion(){
        puntuacion +=1;
        Debug.Log(puntuacion);
    }
}
