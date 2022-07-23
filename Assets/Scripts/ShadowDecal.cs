using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ShadowDecal : MonoBehaviour
{
    public DecalProjector decalProjector;
    Quaternion rotation;

    float xPos;
    float yPos;
    float zPos;

    // Start is called before the first frame update
    void Start()
    {
        rotation = decalProjector.transform.localRotation;
        //xPos = decalProjector.transform.localPosition.x;
        //yPos = decalProjector.transform.localPosition.y;
        //zPos = decalProjector.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        //decalProjector.transform.rotation = Quaternion.Euler(0, 180, 0);
        decalProjector.transform.localRotation = rotation;
        //decalProjector.transform.localPosition = new Vector3(
        //    xPos,
        //    yPos,
        //    zPos);


    }
}
