using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscribirConsola : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Esfera;        
    public GameObject Coche;
    public GameObject Personaje;

    void Start()
    {
        Debug.Log("Hola");
        Esfera = GameObject.Find("Esfera");
        Debug.Log(Esfera.name);

        Coche = GameObject.Find("Coche1");
        Debug.Log(Coche.name);

        Personaje = GameObject.Find("Personaje");
        Debug.Log(Personaje.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
