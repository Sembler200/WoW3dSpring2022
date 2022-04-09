using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTravel : MonoBehaviour
{
    public Scrollbar slide;
    public float scrollScale;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target.transform.position = new Vector3(0.0f, slide.value * scrollScale, 0.0f);
    }
}
