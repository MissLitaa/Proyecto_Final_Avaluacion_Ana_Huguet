using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileBehaviour : MonoBehaviour
{
    private float missileSpeed = 50f;
   
    void Update()
    {
        //Movimiento hacia adelante.
        transform.Translate(Vector3.forward * Time.deltaTime * missileSpeed);

    }

}
