using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessController : MonoBehaviour
{
    public float speed =3f;
    public bool canCharge = false;
    bool canScream = false;

    public AudioSource audioSource;
    public AudioClip screamAudio;

    public Transform target;

    public GameObject laserEyes;
    public GameObject eyes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            canCharge = true;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            audioSource.PlayOneShot(screamAudio);
        }

        if (canCharge)
        {

            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        }

        if (canScream)
        {
            audioSource.PlayOneShot(screamAudio);
            canScream = false;
        }

        if (Vector3.Distance(transform.position, target.position) < 6f)
        {
            laserEyes.SetActive(true);
            eyes.SetActive(false);
            canScream = true;
        }

    }
}
