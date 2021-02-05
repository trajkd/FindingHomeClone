using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGallery : MonoBehaviour
{
    public string sceneToPlay = "Gallery";
    public bool activateFromHome = false;
    public void Play() {
        activateFromHome = true;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
