using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTravel : MonoBehaviour
{
    //DONT NEED ANYMORE
    //Keyframe the timeline instead. Timeline can be keyframed to be more accurate, and have additional components
    public Scrollbar slide;
    public float scrollScale;
    public GameObject target;

    void Update()
    {
        target.transform.position = new Vector3(0.0f, slide.value * scrollScale, 0.0f);
    }
}
