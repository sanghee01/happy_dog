using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(1080, 1920, true);
        // Camera camera = GetComponent<Camera>();
        // Rect rect = camera.rect;

        // float scaleHeight = ((float)Screen.width / Screen.height) / ((float)9 / 16);
        // float scaleWidth = 1f / scaleHeight;
        // if(scaleHeight < 1)
        // {
        //     rect.height = scaleHeight;
        //     rect.y = (1f - scaleHeight) / 2f;
        // }
        // else
        // {
        //     rect.width = scaleWidth;
        //     rect.x = (1f - scaleWidth) / 2f;
        // }
        // camera.rect = rect;
    }
}