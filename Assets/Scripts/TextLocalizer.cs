using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextLocalizer : MonoBehaviour
{
    public static string CurrentLanguage = "English";

    static Dictionary<string, Dictionary<string, string>> Translations = new Dictionary<string, Dictionary<string, string>>() {
        ["English"] = new Dictionary<string, string>() {
            ["back"] = "Back",
            ["choose_a_reply"] = "Choose a reply",
            ["select"] = "Select",
        },
        ["Italiano"] = new Dictionary<string, string>() {
            ["back"] = "Indietro",
            ["choose_a_reply"] = "Scegli una risposta",
            ["select"] = "Seleziona",
        }
    };

    [SerializeField] string id;

    public string ResolveStringValue(string id) {
        return Translations[CurrentLanguage][id];
    }
    
    void Start() {
        GetComponent<TMP_Text>().text = ResolveStringValue(id);
    }
    
    void OnValidate() {
        GetComponent<TMP_Text>().text = ResolveStringValue(id);
    }
}