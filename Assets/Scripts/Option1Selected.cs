using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option1Selected : MonoBehaviour
{
    [SerializeField]GameObject reply;
    [SerializeField]GameObject replyVoiceover;
    [SerializeField]GameObject response;
    [SerializeField]GameObject responseWithImage;
    [SerializeField]GameObject responseWithAffinity;
    public Sprite heart;
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject secondReplyOption;
    [SerializeField]GameObject thirdReplyOption;
    [SerializeField]AudioSource messageSound;
    public bool selectionPossible = true;
    float continueTime = Time.time + 2;
    public static Dictionary<string, Color32> avatarColors;
    public static Dictionary<string, Dictionary<string, string>> avatarNamesTranslations;
    public static int userAffinity = 3;
    void Awake() {
        avatarColors = new Dictionary<string, Color32>();
        avatarColors.Add("user", new Color32(72, 19, 105, 255));
        avatarNamesTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["user"] = "User"
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["user"] = "Utente"
            }
        };
    }
    public IEnumerator Start() {
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstReply(string replyString, Sprite avatar) {
        selectionPossible = false;
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TMP_Text>().text = replyString;
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        ItalianTranslator.Translate(replytext, replyString);
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintReply(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TMP_Text>().text = replyString;
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        ItalianTranslator.Translate(replytext, replyString);
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintReplyVoiceover(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject replygo = Instantiate(replyVoiceover) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TMP_Text>().text = replyString;
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        ItalianTranslator.Translate(replytext, replyString);
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    
    public IEnumerator PaintFirstResponse(string responseString, Sprite avatar) {
        selectionPossible = false;
        GameObject responsego = Instantiate(response) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<TMP_Text>().text = responseString;
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        ItalianTranslator.Translate(responsetext, responseString);
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponse(string responseString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject responsego = Instantiate(response) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<TMP_Text>().text = responseString;
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        ItalianTranslator.Translate(responsetext, responseString);
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponseWithImage(Sprite image, Sprite avatar) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject responsego = Instantiate(responseWithImage) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = image;
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponseWithAffinity(Sprite avatar, bool isPositve) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject responsego = Instantiate(responseWithAffinity) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = heart;
        if (isPositve) {
            responsetext.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        } else {
            responsetext.GetComponent<Image>().color = new Color32(202, 0, 0, 255);
        }
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        if (isPositve) {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(202, 0, 0, 255), 2f);
            LeanTween.scale(responsetext.gameObject.GetComponent<RectTransform>(), responsetext.gameObject.GetComponent<RectTransform>().localScale*1.2f, 1f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong(3);
        } else {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(100, 100, 100, 255), 1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.2f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.3f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.4f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.5f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.6f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.7f);
        }
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstNarrator(string narratorString) {
        selectionPossible = false;
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = narratorString;
        yield return ScrollDown();
        ItalianTranslator.Translate(narratortext, narratorString);
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintNarrator(string narratorString) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = narratorString;
        yield return ScrollDown();
        ItalianTranslator.Translate(narratortext, narratorString);
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintNarratorWithImage(Sprite image) {
        selectionPossible = false;
        yield return waitForSkip();
        GameObject narratorgo = Instantiate(narratorWithImage) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Image");
        narratortext.GetComponent<Image>().preserveAspect = true;
        narratortext.GetComponent<Image>().sprite = image;
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public void ChangeReply(string optionA, string optionB) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TMP_Text>().text = optionA;
        ItalianTranslator.Translate(textA, optionA);
        secondReplyOption.SetActive(true);
        Transform textB = transform.parent.transform.Find("Reply option (1)/Text (TMP)");
        textB.GetComponent<TMP_Text>().text = optionB;
        ItalianTranslator.Translate(textB, optionB);
        thirdReplyOption.SetActive(false);
    }
    public void ChangeReplyWithOneOption(string optionA) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TMP_Text>().text = optionA;
        ItalianTranslator.Translate(textA, optionA);
        secondReplyOption.SetActive(false);
    }
    public void ChangeReplyWithThreeOptions(string optionA, string optionB, string optionC) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TMP_Text>().text = optionA;
        ItalianTranslator.Translate(textA, optionA);
        secondReplyOption.SetActive(true);
        Transform textB = transform.parent.transform.Find("Reply option (1)/Text (TMP)");
        textB.GetComponent<TMP_Text>().text = optionB;
        ItalianTranslator.Translate(textB, optionB);
        thirdReplyOption.SetActive(true);
        Transform textC = transform.parent.transform.Find("Reply option (2)/Text (TMP)");
        textC.GetComponent<TMP_Text>().text = optionC;
        ItalianTranslator.Translate(textC, optionC);
    }
    IEnumerator ScrollDown() {
        ScrollRect scrollrect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();
        yield return new WaitForEndOfFrame();
        scrollrect.verticalNormalizedPosition = 0;
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)scrollrect.transform);
    }
    public void ActivateSelection() {
        selectionPossible = true;
        RectTransform glow = GameObject.Find("Glow").GetComponent<RectTransform>();
        LeanTween.alpha(glow, 1f, 0.4f).setDelay(3f).setLoopPingPong(5);
        GameObject.Find("InputField").GetComponent<Button>().onClick.AddListener(() => CancelTween(GameObject.Find("Glow")));
        GameObject.Find("Select button").GetComponent<Button>().onClick.AddListener(() => CancelTween(GameObject.Find("Glow")));
    }
    void CancelTween(GameObject go) {
        LeanTween.cancel(go);
        Image image = go.GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
    }
    private IEnumerator waitForSkip() {
        bool done = false;
        float continueTime = Time.time + 2;
        while(!done && (Time.time < continueTime)) {
            if(Input.GetMouseButtonDown(0)) {
                done = true;
            }
            yield return null;
        }
    }
    public void SetAffinity(string name, int diff) {
        if (name == "user") {
            userAffinity = Mathf.Clamp(userAffinity+diff, 1, 5);
        }
    }
    public void UnlockAnImage(Sprite image) {
        UnlockImage.images.Add(image);
    }
    public void UnlockAnAchievement(Sprite image) {
        ShowAchievements.achievements.Add(image);
    }
}
