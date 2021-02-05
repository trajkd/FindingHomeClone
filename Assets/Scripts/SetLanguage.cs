using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetLanguage : MonoBehaviour
{
    public void SetTheLanguage() {
        TextLocalizer.CurrentLanguage = this.gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text;
        //PlayerPrefs.SetString("Language", this.gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text);
    }
}
