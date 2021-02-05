using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitChatsMainPanel : MonoBehaviour
{
    [SerializeField]GameObject ChatsMainPanel;

    public void OpenPanel() {
        if (ChatsMainPanel != null) {
            Animator animator1 = ChatsMainPanel.GetComponent<Animator>();
            if (animator1 != null) {
                bool isOpen = animator1.GetBool("open");
                animator1.SetBool("open", !isOpen);
            }
        }
    }
}
