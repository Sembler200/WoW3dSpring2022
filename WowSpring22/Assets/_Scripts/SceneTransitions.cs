using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitions : MonoBehaviour
{
    //DONT NEED THIS. All replaced by sceneFader
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

        yield return new WaitForSeconds(sec);
        sc.LoadScene(toScene);
    }
}
