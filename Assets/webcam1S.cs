using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webcam1S : MonoBehaviour {
    public int webcamNum;
    public RawImage rawimage;

    // Use this for initialization
    void Start () {

        WebCamTexture webcamTexture = new WebCamTexture();
        Debug.Log(WebCamTexture.devices[webcamNum].name);
        webcamTexture.deviceName = WebCamTexture.devices[webcamNum].name;
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
	
}
