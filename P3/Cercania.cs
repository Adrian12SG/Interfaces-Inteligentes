using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cercania : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnCercania;
    // Start is called before the first frame update
    private Rigidbody c;
    private GameObject player;
    void Start()
    {
        c = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PosPlayer = player.transform.position;
        Vector3 PosC = c.transform.position;
        Vector3 mov = Vector3.Normalize(PosC-PosPlayer);
        float dist = Vector3.Distance(PosC,PosPlayer); 
        if (dist <= 5)
        {
            OnCercania();
        }
    }
}
