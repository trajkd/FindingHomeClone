using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToChatsListFromHome : MonoBehaviour
{
    public string sceneToPlay = "ChatsList";
    public bool activateFromHome = false;
    public void Play() {
        activateFromHome = true;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
