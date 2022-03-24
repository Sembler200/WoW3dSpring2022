using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public SceneTransitions st;

    public void ToHula()
    {
        st.toScene = "Hula";
        st.GoTo();
       // FindObjectOfType<SceneController>().LoadScene("Hula");
    }

    public void ToGalilee()
    {
        FindObjectOfType<SceneController>().LoadScene("Galilee");
    }


}
