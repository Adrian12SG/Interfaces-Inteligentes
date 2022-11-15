using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTamaño : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody c;
    private GameObject player;
    private GameObject esfera;
    private Vector3 cambio;
    void Start()
    {
        c = GetComponent<Rigidbody>();
        player = GameObject.Find("Cube");
        esfera = GameObject.FindWithTag("Esfera");
        cambio = new Vector3(0.02f, 0.02f, 0.02f);    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Posplayer = player.transform.position;
        Vector3 PosC = c.transform.position;
        Vector3 PosE = esfera.transform.position;
        float distp = Vector3.Distance(PosC,Posplayer); 
        float diste = Vector3.Distance(PosC,PosE); 

        if (distp <= 5 && transform.localScale.x>0.5)
        {
            transform.localScale -=cambio;
        }
        if (diste <= 5 && transform.localScale.x<5)
        {
            transform.localScale +=cambio;
        }
    }
}
