using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToIshak : MonoBehaviour
{
    public string sceneToPlay = "Ishak";
    public void Play() {
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
