using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToIshakProfile : MonoBehaviour
{
    public string sceneToPlay = "IshakProfile";
    public static Sprite character;
    public void Play() {
        character = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
    }
}
