using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;



public class CivTimeTravel : MonoBehaviour
{
    public Scrollbar sb;
    public PlayableDirector pb;
    public float actTime;
    // Start is called before the first frame update
    void Start()
    {
        pb.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTime()
    {
        Debug.Log(sb.value);
        float maxtime = 1;

        actTime = sb.value * maxtime;

        pb.time = actTime;
        pb.RebuildGraph();
        pb.Play();
        pb.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }
}
