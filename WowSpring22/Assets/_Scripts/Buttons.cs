using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   // public SceneTransitions st;
    public Cinemachine.CinemachineFreeLook cam1, cam2, cam3, mainCam, zoomCam;
    public SceneFader sf;
    public float sec;

    public GameObject hulaInfo, galInfo, bapInfo;

    public void ChangeCam1()
    {
        cam1.Priority = 1;
        cam2.Priority = 0;
        cam3.Priority = 0;
    }

    public void ChangeCam2()
    {
        cam1.Priority = 0;
        cam2.Priority = 1;
        cam3.Priority = 0;

    }

    public void ChangeCam3()
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 1;

    }

    public void ViewMainCam()
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 0;
        mainCam.Priority = 1;
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

    public void OpenInfo(string loc)
    {
        if(loc == "hula")
        {
            hulaInfo.SetActive(true);
        }
        if (loc == "gal")
        {
            galInfo.SetActive(true);
        }
        if (loc == "bap")
        {
            bapInfo.SetActive(true);
        }
    }
    public void CloseInfo()
    {
        hulaInfo.SetActive(false);
        galInfo.SetActive(false);
        bapInfo.SetActive(false);
    }

}
