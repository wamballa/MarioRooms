using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutController : MonoBehaviour
{

    //public GameObject mask;

    public Animator anim;
    bool animPlaying = false;

    void Start()
    {
        
    }


    void Update()
    {

        if (animPlaying) return;

        if (Input.GetKeyDown(KeyCode.O))
        {
            anim.SetBool("canGrow", true);
            animPlaying = true;
            print(">>> GROW");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetBool("canShrink", true);
            animPlaying = true;
            print(">>> SHRINK");
        }


    }

    public void ShrinkMe()
    {
        anim.SetBool("canGrow", false);
        anim.SetBool("canShrink", true);
        animPlaying = true;
    }
    public void GrowMe()
    {
        anim.SetBool("canGrow", true);
        anim.SetBool("canShrink", false);
        animPlaying = true;
    }

    public void AnimationFinished()
    {
        print("Animation Finished");
        animPlaying = false;
        anim.SetBool("canGrow", false);
        anim.SetBool("canShrink", false);
    }
    public void  ShrinkFinished()
    {
        print("Animation Finished");
        animPlaying = false;
        //anim.SetBool("canGrow", false);
        //anim.SetBool("canShrink", false);
    }
    public void GrowFinished()
    {
        print("Animation Finished");
        animPlaying = false;
        anim.SetBool("canGrow", false);
        anim.SetBool("canShrink", false);
    }

}
