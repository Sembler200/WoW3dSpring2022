using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Cinemachine.CinemachineFreeLook cam1, cam2, cam3, mainCam, zoomCam;
    public SceneFader sf;
    public float sec;

    public GameObject hulaInfo, galInfo, bapInfo, landInfo, birdInfo;


    //makes cam 1 priority
    public void ChangeCam1()
    {
        cam1.Priority = 1;
        cam2.Priority = 0;
        cam3.Priority = 0;
    }

    //makes cam 2 priority
    public void ChangeCam2()
    {
        cam1.Priority = 0;
        cam2.Priority = 1;
        cam3.Priority = 0;

    }

    //makes cam 3 priority
    public void ChangeCam3()
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 1;

    }

    //makes main cam priority
    public void ViewMainCam()
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 0;
        mainCam.Priority = 1;
    }

    //dont need this, use the scene fader instead
    public void ChangeScene(string scene)
    {
        
        StartCoroutine(ZoomSwitch(scene));
    }

    IEnumerator ZoomSwitch(string scene)
    {
        //we had a camera focused onto close up of map and would switch to this cam then change scene
        //this isnt needed anymore and we switch another way
        zoomCam.Priority = 10;
        yield return new WaitForSeconds(sec);
        sf.FadeTo(scene);
    }

    public void OpenInfo(GameObject canvas)
    {
        //deactivates all canvases then opens canvas we want
        hulaInfo.SetActive(false);
        galInfo.SetActive(false);
        bapInfo.SetActive(false);
        landInfo.SetActive(false);
        birdInfo.SetActive(false);
        canvas.SetActive(true);


       
    }
    public void CloseInfo()
    {
        //closes all info gameobjects, will need to add more here if want to add more canvases
        hulaInfo.SetActive(false);
        galInfo.SetActive(false);
        bapInfo.SetActive(false);
        landInfo.SetActive(false);
        birdInfo.SetActive(false);
    }


}
