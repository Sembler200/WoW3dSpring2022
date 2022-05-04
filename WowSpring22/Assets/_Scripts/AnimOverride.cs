using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOverride : MonoBehaviour
{
    //overrides the animation
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void SetAnim(AnimatorOverrideController overrideController)
    {
        anim.runtimeAnimatorController = overrideController;
    }
}
