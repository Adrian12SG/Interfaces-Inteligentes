using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
    private Puntaje Puntajecubo = new Puntaje();
    private Vector3 aumento;
    // Start is called before the first frame update
    void Start()
    {
        
        aumento = new Vector3(0.5f, 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision colision){
        if (colision.collider.CompareTag("Player"))
        {
            transform.localScale +=aumento;
            Puntajecubo.AumentarPuntuacion();
        }

    }
}
