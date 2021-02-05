using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenReplyPanel : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    [SerializeField]GameObject ReplyPanel;
    GameObject ChatsMainPanel;
    public void Start() {
        ChatsMainPanel = GameObject.Find("Chats Main Panel");

        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            animator1.SetBool("exitSpecificChat", false);
        }
    }

    public void SlideOut() {

        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            animator1.SetBool("exitSpecificChat", true);
        }
        if (ChatsMainPanel != null) {
            Animator animator2 = ChatsMainPanel.GetComponent<Animator>();
            if (animator2 != null) {
                bool isOpen = animator2.GetBool("open");
                animator2.SetBool("open", !isOpen);
            }
        }
        StartCoroutine("unloadSpecificChat");
    }

    IEnumerator unloadSpecificChat() {
        yield return new WaitForSeconds(3f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }

    public void OpenPanel() {
        if(GameObject.Find("Reply option").GetComponent<Option1Selected>().selectionPossible) {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                if (animator1 != null) {
                    bool isOpen = animator1.GetBool("open");
                    animator1.SetBool("open", !isOpen);
                }
            }

            if (ReplyPanel != null) {
                Animator animator2 = ReplyPanel.GetComponent<Animator>();
                if (animator2 != null) {
                    bool isOpen = animator2.GetBool("open");
                    animator2.SetBool("open", !isOpen);
                }
            }
        }
    }
}
