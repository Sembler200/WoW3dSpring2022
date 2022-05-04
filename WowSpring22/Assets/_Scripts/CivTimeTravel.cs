using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.Timeline;




public class CivTimeTravel : MonoBehaviour
{
    public Scrollbar sb;
    public PlayableDirector pb;
    public float actTime;

    public TimelineAsset savedtimeline;

    public Text buttonText;
    public bool isHelp = false;

    void Start()
    {
        pb.playableGraph.GetRootPlayable(0).SetSpeed(0);
    }

    //makes timeline move with graph. Timeline can only go to 60frames
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

    //gets the tracks in the timeline and makes sure one is muted
    public void MuteUnmuteTrack(int trackIndex)
    {
        TrackAsset myTrack = savedtimeline.GetOutputTrack(trackIndex);

        myTrack.muted = !myTrack.muted;
       // pb.RebuildGraph();
    }

    //mutes active timeline anim and unmutes the unactive one
    //seamless so you can switch between the 2 timelines
    public void SwitchTimeline()
    {
        MuteUnmuteTrack(1);
        MuteUnmuteTrack(2);
        if (isHelp)
        {
            buttonText.text = "Help the Earth?";
            isHelp = false;
        } else
        {
            buttonText.text = "Earth helped";
            isHelp = true;
        }
    }




}
