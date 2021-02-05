using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageToggler : MonoBehaviour
{
    [SerializeField]GameObject englishToggler;
    [SerializeField]GameObject italianToggler;
    void Start()
    {
        if (TextLocalizer.CurrentLanguage == "Italiano") {
            englishToggler.SetActive(false);
            italianToggler.SetActive(true);
        }
        englishToggler.GetComponent<Button>().onClick.AddListener(() => SetLanguage("Italiano"));
        italianToggler.GetComponent<Button>().onClick.AddListener(() => SetLanguage("English"));
    }
    void SetLanguage(string languageToSwitchTo) {
        TextLocalizer.CurrentLanguage = languageToSwitchTo;
        if (languageToSwitchTo == "English") {
            italianToggler.SetActive(false);
            englishToggler.SetActive(true);
        } 
        else if (languageToSwitchTo == "Italiano") {
            englishToggler.SetActive(false);
            italianToggler.SetActive(true);
        }
    }
}
