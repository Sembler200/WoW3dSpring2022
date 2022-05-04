using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;

    //use if want 2d animals to constantly look at cam
    void Update()
    {
        transform.LookAt(target);
    }
}
