using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChatsApp : MonoBehaviour
{
    [SerializeField]GameObject ChatsMainPanel;
    void Start()
    {
        if (GameObject.Find("app (4)").GetComponent<GoToChatsListFromHome>().activateFromHome) {
            if (ChatsMainPanel != null) {
                Animator animator1 = ChatsMainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        }
    }
}
