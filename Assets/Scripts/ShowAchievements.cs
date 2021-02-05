using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowAchievements : MonoBehaviour
{
    [SerializeField]GameObject noAchievementsYet;
    [SerializeField]GameObject simpleImage;
    [SerializeField]GameObject popupBackground;
    [SerializeField]GameObject achievementPopup;
    public static List<Sprite> achievements = new List<Sprite>();
    Dictionary<string, Dictionary<string, Tuple<string, string>>> achievementsTitlesAndDescriptions;
    public void Start() {
        achievementsTitlesAndDescriptions = new Dictionary<string, Dictionary<string, Tuple<string, string>>>() {
            ["English"] = new Dictionary<string, Tuple<string, string>>() {
                ["founder"] = new Tuple <string, string>("First choice", "Make your first choice")
            },
            ["Italiano"] = new Dictionary<string, Tuple<string, string>>() {
                ["founder"] = new Tuple <string, string>("Prima scelta", "Fai la tua prima scelta")
            }
        };
        if (achievements.Count > 0) {
            noAchievementsYet.SetActive(false);
            GameObject line1 = GameObject.Find("Line of badges 1");
            for (int i = 0; i < achievements.Count; i++) {
                Debug.Log(i);
                GameObject image = Instantiate(simpleImage) as GameObject;
                image.transform.parent = line1.transform;
                image.GetComponent<Image>().sprite = achievements[i];
                string achievementName = achievements[i].name;
                image.GetComponent<Button>().onClick.AddListener(() => OpenAchievementPopup(achievementName));
            }
        }
    }
    public void OpenAchievementPopup(string achievementName) {
        popupBackground.SetActive(true);
        GameObject ap = Instantiate(achievementPopup) as GameObject;
        ap.SetActive(false);
        ap.transform.parent = GameObject.Find("Profile Main Panel").transform;
        ap.GetComponent<RectTransform>().localPosition = new Vector3(0, -140, 0);
        Transform achievementTitle = ap.transform.Find("Achievement title");
        Transform achievementDescription = ap.transform.Find("Achievement description");
        GameObject closeButton = ap.transform.Find("Close button").gameObject;
        achievementTitle.GetComponent<TMP_Text>().text = achievementsTitlesAndDescriptions[TextLocalizer.CurrentLanguage][achievementName].Item1;
        achievementDescription.GetComponent<TMP_Text>().text = achievementsTitlesAndDescriptions[TextLocalizer.CurrentLanguage][achievementName].Item2;
        closeButton.GetComponent<Button>().onClick.AddListener(() => CloseAchievementPopup(ap));
        ap.SetActive(true);
    }
    void CloseAchievementPopup(GameObject popupToClose) {
        popupBackground.SetActive(false);
        Destroy(popupToClose);
    }
}