using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float chopperSpeed = 25f;
    private float chopperTurnSpeed = 30f;

    private float horizontalAxis;
    private float verticalAxis;
    private Vector3 initialPos = new Vector3(0, 100, 0);
    private float generalLimit = 200;

    public GameObject missilePrefab;
    private Vector3 missileOffset;
    private float missileOffsetValue = -2f;

    public AudioSource playerAS;
    public AudioClip explosionBarrel;
    public AudioClip explosionChopper;
    public AudioClip coinCollect;

    // Update is called once per frame
    private void Start()
    {
        //Posici�n inicial
        transform.position = initialPos;

        //Offset del misil.
        missileOffset = new Vector3(transform.position.x, missileOffsetValue, transform.position.z);

        //Accedemos a los componentes de Player.
        playerAS = GetComponent<AudioSource>();

        
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

        //Disparar misil (a�ado un offset por que quiero que parezca que de verdad sale del helic�ptero).

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(missilePrefab, transform.position + missileOffset, transform.rotation);
        }

     
    }


}
