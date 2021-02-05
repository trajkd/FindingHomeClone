using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToHome : MonoBehaviour
{
    [SerializeField]GameObject ChatsMainPanel;
    public void SlideOut() {
        if (ChatsMainPanel != null) {
            Animator animator1 = ChatsMainPanel.GetComponent<Animator>();
            if (animator1 != null) {
                animator1.SetTrigger("toHome");
            }
        }
        StartCoroutine("unloadChatsList");
    }

    IEnumerator unloadChatsList() {
        yield return new WaitForSeconds(3f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
