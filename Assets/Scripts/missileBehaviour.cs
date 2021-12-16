using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileBehaviour : MonoBehaviour
{
    private float missileSpeed = 50f;
    public AudioSource missileSource;
    public AudioClip missileASExplosion;


    private void Start()
    {
        missileSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        //Movimiento hacia adelante.
        transform.Translate(Vector3.forward * Time.deltaTime * missileSpeed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Barrel"))
        {
            missileSource.PlayOneShot(missileASExplosion, 1f);
            Destroy(other.gameObject);
        }

      

    }
}
