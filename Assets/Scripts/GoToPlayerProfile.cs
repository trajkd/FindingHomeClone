using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlayerProfile : MonoBehaviour
{
    public string sceneToPlay = "PlayerProfile";
    public void Play() {
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
