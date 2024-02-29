using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorcolumnas : MonoBehaviour
{
    public int puntuacion = 0;
    public int puntosPorColumna = 1;
    
    void OnTriggerExit(){
        puntuacion=puntuacion+puntosPorColumna;
    }
}
