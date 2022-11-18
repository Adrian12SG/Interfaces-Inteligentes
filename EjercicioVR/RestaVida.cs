using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaVida : MonoBehaviour
{

    private GameObject araña;
    private GameObject player;
    private int vida;
    
    // Start is called before the first frame update
    void Start()
    {
        araña = GameObject.FindWithTag("Araña");
        player = GameObject.FindWithTag("Player");
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Posplayer = player.transform.position;
        Vector3 Posaraña = araña.transform.position;
        float distp = Vector3.Distance(Posaraña,Posplayer);

        if (distp <= 5 && vida>0)
        {
            vida = vida-10;
            Debug.Log("Vida: "+vida);
        }

    }
}
