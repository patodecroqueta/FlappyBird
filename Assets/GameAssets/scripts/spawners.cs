using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawners : MonoBehaviour
{
    public GameObject prefab;
    public int numeroElementos;
    public int tiempoEntreSpawn;
    private int contador = 0;
    void Start()
    {
        InvokeRepeating("Spawn",tiempoEntreSpawn, tiempoEntreSpawn);
    }
    void Spawn(){
        contador++;
        Instantiate(prefab, transform);
        if (contador>=numeroElementos){
            CancelInvoke("Spawn");
        }
    }
}
