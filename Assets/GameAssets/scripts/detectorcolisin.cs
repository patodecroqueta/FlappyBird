using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectorcolision : MonoBehaviour
{
    public GameObject prefabExplosion;
    void OnCollisionEnter(){
      Instantiate(prefabExplosion,transform.position, prefabExplosion.transform.rotation);
      Destroy(gameObject);
    }
}
