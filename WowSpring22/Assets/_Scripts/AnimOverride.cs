using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOverride : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void SetAnim(AnimatorOverrideController overrideController)
    {
        anim.runtimeAnimatorController = overrideController;
    }
}
