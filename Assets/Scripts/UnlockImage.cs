using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockImage : MonoBehaviour
{
    public static List<Sprite> images = new List<Sprite>();
    public void UnlockAnImage(Sprite image) {
        images.Add(image);
    }
}
