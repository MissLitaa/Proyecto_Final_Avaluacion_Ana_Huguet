using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float chopperSpeed = 25f;
    private float chopperTurnSpeed = 30f;

    private float horizontalAxis;
    private float verticalAxis;

    private float generalLimit = 200;

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

        //Asignaci�n de teclas para las rotaciones en ejes.

        transform.Rotate(Vector3.up, chopperTurnSpeed * Time.deltaTime * horizontalAxis);
        transform.Rotate(Vector3.left, chopperTurnSpeed * Time.deltaTime * verticalAxis);

        //L�mite eje Z.

        if (transform.position.z >= generalLimit )
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, generalLimit);
        }
        if (transform.position.z <= -generalLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -generalLimit);
        }


        //L�mite Y.

        if (transform.position.y >= generalLimit)
        {
            transform.position = new Vector3(transform.position.x, generalLimit, transform.position.z);
        }
        if (transform.position.y <= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        //L�mite X.

        if (transform.position.x >= generalLimit)
        {
            transform.position = new Vector3(generalLimit, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -generalLimit)
        {
            transform.position = new Vector3(-generalLimit, transform.position.y, transform.position.z);
        }
    }
}
