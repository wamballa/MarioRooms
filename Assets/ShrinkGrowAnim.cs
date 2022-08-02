using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkGrowAnim : MonoBehaviour
{

    public Animation anim;



    // Start is called before the first frame update
    void Start()
    {
        //foreach(AnimationState state in anim)
        //{
        //    print("Anim State = " + state.name);

        //}
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ShrinkAnim()
    {
        print("Play SHRINK ANIMATION");
        //anim.Play("CircleShrink");
        //anim.Play()
    }
}
