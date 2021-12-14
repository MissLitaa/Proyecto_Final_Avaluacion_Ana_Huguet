using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Vector3 rotationAspas;
    private float grados = 360f;
    private float gradosCoin = 90f;

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.CompareTag("Aspa"))
        { 
            transform.Rotate(Vector3.up, grados * Time.deltaTime, Space.Self);
        }

        if (gameObject.CompareTag("Coin"))
        {
            transform.Rotate(Vector3.up, gradosCoin * Time.deltaTime, Space.Self);
        }
    }

    
}
