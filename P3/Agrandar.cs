using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agrandar : MonoBehaviour
{
    
    public ColisionA colisionA;
    public ColisionA colisionA2;
    public ColisionA colisionA3;
    public Cercania cercania;
    // Start is called before the first frame update
    void Start()
    {
        
        
        colisionA.OnAgrandarB += agrandarB;
        colisionA2.OnAgrandarB += agrandarB;
        colisionA3.OnAgrandarB += agrandarB;
        cercania.OnCercania+= mirarCilindro;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void agrandarB(){
        //Rigidbody a = GetComponent<Rigidbody>();
        GameObject[] b = GameObject.FindGameObjectsWithTag("B");
        Vector3 aumento = new Vector3(0.5f, 0.5f, 0.5f);
        for (int i = 0; i < b.Length; i++)
        {
            
            b[i].transform.localScale = b[i].transform.localScale+aumento;
        }
        
    }

    void mirarCilindro(){
        GameObject[] b = GameObject.FindGameObjectsWithTag("B");
        GameObject cilindro = GameObject.FindWithTag("Finish");
        Vector3 posCilindro = cilindro.transform.position;
        for (int i = 0; i < b.Length; i++)
        {
            b[i].transform.LookAt(posCilindro);
        }
    }
}
