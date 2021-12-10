using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float chopperSpeed = 25f;
    private float chopperTurnSpeed = 30f;

    private float horizontalAxis;
    private float verticalAxis;

    private float generalLimit;

    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        //Acceso a los ejes.
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        //Movimiento hacia adelante.
        transform.Translate(Vector3.forward * Time.deltaTime * chopperSpeed);

        //Asignación de teclas para las rotaciones en ejes.

        transform.Rotate(Vector3.up, chopperTurnSpeed * Time.deltaTime * horizontalAxis);
        transform.Rotate(Vector3.left, chopperTurnSpeed * Time.deltaTime * verticalAxis);

        /*Límite rotación horizontal.

        if (transform.rotation.z < generalLimit )
        {
            transform.rotation *= Quaternion.Euler(0, generalLimit, 0);
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, -generalLimit, 0);
        }

        //Límite rotación horizontal.

        if (transform.rotation.x < generalLimit)
        {
            transform.rotation *= Quaternion.Euler(generalLimit, 0, 0);
        }
        else
        {
            transform.rotation *= Quaternion.Euler(-generalLimit, 0, 0);
        }*/
    }
}
