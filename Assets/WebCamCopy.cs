using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamCopy : MonoBehaviour {
    public RawImage rawimageCopiedFrom;
    public RawImage rawimageCopiedTo;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        rawimageCopiedTo.texture = rawimageCopiedFrom.texture;
        rawimageCopiedTo.material.mainTexture = rawimageCopiedFrom.material.mainTexture;
    }
}
