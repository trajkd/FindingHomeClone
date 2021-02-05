using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AffinityPainter : MonoBehaviour
{
    Dictionary<string, int> avatarAffinities;
    void Start()
    {
        avatarAffinities = new Dictionary<string, int>() {
            ["user"] = Option1Selected.userAffinity
        };
        GameObject.Find("Circular mask/Big character image").GetComponent<Image>().sprite = GoToIshakProfile.character;
        GameObject.Find("Profile Main Panel/Top bar/Title").GetComponent<Text>().text = Option1Selected.avatarNamesTranslations[TextLocalizer.CurrentLanguage][GoToIshakProfile.character.name];
        if (avatarAffinities[GoToIshakProfile.character.name] == 1) {
            GameObject.Find("Heart 1").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 2").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 3").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 2) {
            GameObject.Find("Heart 1").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 2").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 3").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 3) {
            GameObject.Find("Heart 1").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 2").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 3").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Neutral";
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(100, 100, 100, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 4) {
            GameObject.Find("Heart 1").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 2").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 3").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 4").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 5) {
            GameObject.Find("Heart 1").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 2").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 3").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 4").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Heart 5").GetComponent<Image>().color = new Color32(202, 0, 0, 255);
            GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
    }
}
