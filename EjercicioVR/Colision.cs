using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
    private GameObject huevo;
    private Vector3 aumento;
    // Start is called before the first frame update
    void Start()
    {
        huevo = GameObject.FindWithTag("Huevo");
        aumento = new Vector3(0.5f, 0.5f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision colision){
        if (colision.collider.CompareTag("Player"))
        {
            huevo.transform.localScale +=aumento;
            
        }

    }

}
