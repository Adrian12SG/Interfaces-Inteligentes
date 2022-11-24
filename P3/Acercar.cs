using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acercar : MonoBehaviour
{
    
    public ColisionB colisionB;
    public ColisionB colisionB2;
    public ColisionB colisionB3;

    public Cercania cercania;
    // Start is called before the first frame update
    void Start()
    {
        
        
        colisionB.OnAcercarA += acercaraC;                
        colisionB2.OnAcercarA += acercaraC;
        colisionB3.OnAcercarA += acercaraC;

        cercania.OnCercania += cambColorSalta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void acercaraC(){
        //Rigidbody a = GetComponent<Rigidbody>();
        GameObject c = GameObject.FindWithTag("C");
        GameObject[] a = GameObject.FindGameObjectsWithTag("A");
         
        for (int i = 0; i < a.Length; i++)
        {
            Vector3 posA = a[i].transform.position;
            Vector3 posC = c.transform.position;
            Vector3 dir = Vector3.Normalize(posC-posA);
            a[i].transform.position = a[i].transform.position + dir*1.5f;    
        }
        
    }

    void cambColorSalta(){
        GameObject[] a = GameObject.FindGameObjectsWithTag("A");
        

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].transform.position.y <= 1.1)
            {
                Vector3 salto = new Vector3(0f,1.1f,0f);
                a[i].transform.position = a[i].transform.position + salto; 
                if (a[i].GetComponent<Renderer>().material.color == Color.red)
                {
                    a[i].GetComponent<Renderer>().material.color = Color.yellow;
                }else{
                    a[i].GetComponent<Renderer>().material.color = Color.red;
                }
                
            }

            
               
        }
    }
}
