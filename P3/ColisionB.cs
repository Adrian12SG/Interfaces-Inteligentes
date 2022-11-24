using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionB : MonoBehaviour
{
    
    public delegate void mensaje();
    public event mensaje OnAcercarA;
    
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision colision){
        if (colision.collider.CompareTag("Player"))
        {
            OnAcercarA();
            
        }

    }
}
