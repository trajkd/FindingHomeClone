using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanInToChat : MonoBehaviour
{
    [SerializeField]GameObject ProfileMainPanel;
    public void Start() {
        if (ProfileMainPanel != null) {
            Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
            animator1.SetBool("panIn", false);
        }
    }

    public void PanIn() {
        if (ProfileMainPanel != null) {
            Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
            animator1.SetBool("panIn", true);
        }
        StartCoroutine("unloadProfile");
    }

    IEnumerator unloadProfile() {
        yield return new WaitForSeconds(3f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
