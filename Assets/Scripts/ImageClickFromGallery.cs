using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClickFromGallery : MonoBehaviour
{
    static GameObject theImage;
    static GameObject theZoomedImage;
    static GameObject originalParent;
    static Vector3 prevPos;
    public static bool zoomed = false;
    public void OnClick()
    {
        if (!zoomed) {
            zoomed = true;
            theImage = gameObject;
            originalParent = transform.parent.gameObject;
            prevPos = transform.position;
            theZoomedImage = GameObject.Instantiate(theImage);
            theZoomedImage.transform.position = prevPos;
            theZoomedImage.GetComponent<Image>().preserveAspect = true;
            theZoomedImage.GetComponent<RectTransform>().sizeDelta = new Vector2 (130, 130);
            theZoomedImage.transform.parent = GameObject.Find("Image container").transform;
            LeanTween.move(theZoomedImage, new Vector3(Screen.width*0.5f, Screen.height*0.5f, 0), 0.2f);
            float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
            float worldScreenWidth = (worldScreenHeight / Screen.height) * Screen.width;
            float imageWidth = GetComponent<RectTransform>().rect.width;
            LeanTween.scaleX(theZoomedImage, Screen.width/imageWidth, 0.2f);
            LeanTween.scaleY(theZoomedImage, Screen.width/imageWidth, 0.2f);
            GameObject.Find("Zoom background").GetComponent<Image>().raycastTarget = true;
            RectTransform zoomBg = GameObject.Find("Zoom background").GetComponent<RectTransform>();
            LeanTween.alpha(zoomBg, 1f, 0.2f);
            GameObject.Find("Back from zoom").GetComponent<Image>().raycastTarget = true;
            RectTransform backFromZoomButton = GameObject.Find("Back from zoom").GetComponent<RectTransform>();
            LeanTween.alpha(backFromZoomButton, 1f, 0.2f);
        }
    }
    public void OnBackClick() {
        GameObject.Find("Zoom background").GetComponent<Image>().raycastTarget = false;
        RectTransform zoomBg = GameObject.Find("Zoom background").GetComponent<RectTransform>();
        LeanTween.alpha(zoomBg, 0f, 0.2f);
        GameObject.Find("Back from zoom").GetComponent<Image>().raycastTarget = false;
        RectTransform backFromZoomButton = GameObject.Find("Back from zoom").GetComponent<RectTransform>();
        LeanTween.alpha(backFromZoomButton, 0f, 0.2f);
        LeanTween.move(theZoomedImage, prevPos, 0.2f);
        LeanTween.scaleX(theZoomedImage, 1f, 0.2f);
        LeanTween.scaleY(theZoomedImage, 1f, 0.2f);
        Destroy(theZoomedImage, 0.2f);
        zoomed = false;
    }
}
