using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItalianTranslator : MonoBehaviour
{
    static Dictionary<string, string> italianTranslations;
    void Start()
    {
        italianTranslations = new Dictionary<string, string>() {
            ["The phone works"] = "Il telefono funziona",
        };
    }
    void Update()
    {
        
    }
    public static void Translate(Transform textField, string stringToTranslate) {
        if (TextLocalizer.CurrentLanguage == "Italiano" && italianTranslations.ContainsKey(stringToTranslate)) {
            textField.GetComponent<TMP_Text>().text = italianTranslations[stringToTranslate];
        }
    }
}
