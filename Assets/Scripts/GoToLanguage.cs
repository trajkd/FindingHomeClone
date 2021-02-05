using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLanguage : MonoBehaviour
{
    public string sceneToPlay = "Language";
    public bool activateFromHome = false;
    public void Play() {
        activateFromHome = true;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
