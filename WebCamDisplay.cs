using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamDisplay : MonoBehaviour
{
    [SerializeField]
    UnityEngine.UI.RawImage rawImage;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log("Webcam available: " + devices[i].name);
        }               

        // Assuming the first available WebCam is desired
        WebCamTexture webCamTexture = new WebCamTexture(devices[0].name);
        // Attach script to GameObject. i.e Plane.
        // Renderer renderer = this.GetComponentInChildren<Renderer>();
        // renderer.material.mainTexture = webCamTexture;
        rawImage.texture = webCamTexture;
        webCamTexture.Play();
    }
}
