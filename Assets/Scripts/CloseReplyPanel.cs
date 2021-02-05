using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseReplyPanel : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    [SerializeField]GameObject ReplyPanel;

    public void ClosePanel() {
        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            if (animator1 != null) {
                animator1.SetBool("open", false);
            }
        }

        if (ReplyPanel != null) {
            Animator animator2 = ReplyPanel.GetComponent<Animator>();
            if (animator2 != null) {
                animator2.SetBool("open", false);
            }
        }
    }
}
