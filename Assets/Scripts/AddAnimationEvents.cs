using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAnimationEvents : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip footStepClip;
    public CameraShake cameraShake;
    public float cameraShakeTime = .1f;

    Animator animator;

    int fps = 30;
    bool canShake = false;

    // Start is called before the first frame update
    void Start()
    {
        print("START");

        // 30 frames = 1 second
        // 15 frames = 0.5

        // t = 30 / frame
        float time = 0.5f;
        AddEvent(0, time , "HeavyFootstep", 0);
        time += 1.25f;
        AddEvent(0, time, "HeavyFootstep", 0);
        time += 1.3f;
        AddEvent(0, time, "HeavyFootstep", 0);
        time += 1.4f;
        AddEvent(0, time, "HeavyFootstep", 0);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            //Make sure to assign the value of shakeFrequency in the inspector 
            //or uncomment the next line to assign it here.
            //shakeFrequency = 0.2f;

            cameraShake.CameraShakes();
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            cameraShake.StopShake();
        }

        HandleShaking();
    }
    void HandleShaking()
    {
        if (canShake)
        {
            cameraShake.CameraShakes();
        }
        else
        {
            cameraShake.StopShake();
        }
    }

    void AddEvent(int Clip, float time, string functionName, float floatParameter)
    {
        animator = GetComponent<Animator>();
        AnimationEvent animationEvent = new AnimationEvent();
        animationEvent.functionName = functionName;
        animationEvent.floatParameter = floatParameter;
        animationEvent.time = time;
        AnimationClip clip = animator.runtimeAnimatorController.animationClips[Clip];
        clip.AddEvent(animationEvent);
    }

    public void HeavyFootstep(float f)
    {
        audioSource.PlayOneShot(footStepClip);
        StartCoroutine(StartCameraShaking());
    }

    IEnumerator StartCameraShaking()
    {
        yield return new WaitForSeconds(.3f);
        canShake = true;
        StartCoroutine(StopCameraShaking());
    }

    IEnumerator StopCameraShaking()
    {
        yield return new WaitForSeconds(cameraShakeTime);
        canShake = false;
    }
}
