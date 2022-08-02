using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject BackRooms;
    public GameObject MarioWorld;

    public Transform pipe1;
    public Transform pipe2;

    public Transform player;
    public AudioSource audioSource;
    public AudioClip pipeTravelClip;

    //public GameObject camera;

    public GameObject blackoutCanvas;

    public MarioController marioController;

    public CutoutController cutoutController;


    bool atPipe1 = true;

    // Start is called before the first frame update
    void Start()
    {
        cutoutController.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleport(string pipeName)
    {
        print("Pipe to teleport to is: " + pipeName);
        //camera.SetActive(false);
        blackoutCanvas.SetActive(true);
        audioSource.PlayOneShot(pipeTravelClip);


        if (pipeName == "Pipe2")
        {
            BackRooms.SetActive(false);
            MarioWorld.SetActive(true);
            player.position = pipe2.position;
            StartCoroutine(TimedTeleport());
            StartCoroutine(MarioTalk());

        }
        if (pipeName == "Pipe1")
        {
            BackRooms.SetActive(true);
            MarioWorld.SetActive(false);
            player.position = pipe1.position;
            StartCoroutine(TimedTeleport());

        }
    }

    IEnumerator TimedTeleport()
    {
        cutoutController.GrowMe();
        yield return new WaitForSeconds(1);
        //blackoutCanvas.SetActive(false);
        //player.position = pos;

    }

    IEnumerator MarioTalk()
    {
        yield return new WaitForSeconds(2);
        marioController.MarioTalk();
    }
}
