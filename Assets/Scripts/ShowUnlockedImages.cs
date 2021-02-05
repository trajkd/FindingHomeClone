using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUnlockedImages : MonoBehaviour
{
    List<Sprite> unlockedImages = UnlockImage.images;
    public void Start() {
        for (int i = 0; i < unlockedImages.Count; i++) {
            this.gameObject.transform.GetChild(i).GetComponent<Image>().sprite = unlockedImages[i];
        }
    }
}