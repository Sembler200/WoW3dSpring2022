using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitions : MonoBehaviour
{
    public Animator transition;
    public float sec;
    public SceneController sc;
    public string toScene;

    public Camera cam;

    public void GoTo()
    {

        StartCoroutine(Transition());
    }
    public IEnumerator Transition()
    {
        //transition.SetTrigger("Start");
        //cam.fieldOfView += 30;
        yield return new WaitForSeconds(sec);
        sc.LoadScene(toScene);
    }
}
