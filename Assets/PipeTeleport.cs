using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTeleport : MonoBehaviour
{

    string pipeName;
    public GameManager gameManager;

    public CutoutController cutoutController;

    // Start is called before the first frame update
    void Start()
    {
        pipeName = transform.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (pipeName == "Pipe1")
        {
            cutoutController.ShrinkMe();
            //gameManager.Teleport("Pipe2");
            StartCoroutine(HandleTeleport("Pipe2"));
        }
        if (pipeName == "Pipe2")
        {
            cutoutController.ShrinkMe();
            //gameManager.Teleport("Pipe1");
            StartCoroutine(HandleTeleport("Pipe1"));
        }
    }

    IEnumerator HandleTeleport(string pipeName)
    {
        yield return new WaitForSeconds(1);
        gameManager.Teleport(pipeName);
    }

}
