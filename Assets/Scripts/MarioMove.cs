using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMove : MonoBehaviour
{
    float speed = .5f;
    public Transform target;
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Vector3.Distance (transform.position, target.position) < 1f)
        {
            print("BIG MARIO WITHIN TARGET");
        }

    }
}
