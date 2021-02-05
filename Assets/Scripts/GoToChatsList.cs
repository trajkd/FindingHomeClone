using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToChatsList : MonoBehaviour
{
    public void GoBack() {
        SceneManager.LoadScene("ChatsList");
    }
}
