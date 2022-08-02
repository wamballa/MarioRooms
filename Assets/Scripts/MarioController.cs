using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }

    public void MarioTalk()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
