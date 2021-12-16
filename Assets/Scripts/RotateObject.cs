using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Vector3 rotationAspas;
    private float grados = 360f;
    private float gradosCoin = 90f;
    private float gradosBarrel = 45f;

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Rota sobre su eje X para simular movimiento.
        if(gameObject.CompareTag("Aspa"))
        { 
            transform.Rotate(Vector3.up, grados * Time.deltaTime, Space.Self);
        }

        //Rota sobre su eje Y.
        if (gameObject.CompareTag("Coin"))
        {
            transform.Rotate(Vector3.up, gradosCoin * Time.deltaTime, Space.Self);
        }

        //Rota sobre su eje Z para simular caída por peso.
        if (gameObject.CompareTag("Barrel"))
        {
            transform.Rotate(Vector3.right, gradosBarrel * Time.deltaTime, Space.Self);
        }
    }

    
}
