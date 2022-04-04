using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   // public SceneTransitions st;
    public Cinemachine.CinemachineFreeLook cam1, cam2, zoomCam;
    public SceneFader sf;
    public float sec;

    public void ChangeCam1()
    {
        cam1.Priority = 1;
        cam2.Priority = 0;
    }

    public void ChangeCam2()
    {
        cam1.Priority = 0;
        cam2.Priority = 1;
    }

    public void ChangeScene(string scene)
    {
        StartCoroutine(ZoomSwitch(scene));
    }

    IEnumerator ZoomSwitch(string scene)
    {
        zoomCam.Priority = 10;
        yield return new WaitForSeconds(sec);
        sf.FadeTo(scene);
    }



}
