using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image image;
    public AnimationCurve fadeCurve;

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    //fades to scene you want
    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

    IEnumerator FadeIn()
    {
        //on scene open, runs quick fade from white
        float t = 1f;

        while (t > 0)
        {
            t -= Time.deltaTime * 1f;
            float a = fadeCurve.Evaluate(t);  //does a fade in curve over time
            image.color = new Color(255f, 255f, 255f, a);
            yield return 0; //skip to next frame
        }


    }


    IEnumerator FadeOut(string scene)
    {
        //on scene out fades to white then switches scene, works nice with fade in
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime * 1f;
            float a = fadeCurve.Evaluate(t);  //does a fade in curve over time
            image.color = new Color(255f, 255f, 255f, a);
            yield return 0; //skip to next frame
        }

        SceneManager.LoadScene(scene);


    }
}
