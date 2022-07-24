using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioFootCollission : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {

            //Instantiate(marker, other.transform.position, Quaternion.identity);

            rb.AddExplosionForce(
                300,
                other.transform.position,
                30,
                3f
                );

            rb.useGravity = true;
        }



    }

}
