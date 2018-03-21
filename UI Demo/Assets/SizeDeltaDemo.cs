using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDeltaDemo : MonoBehaviour {
    private RectTransform _myRectTransform;

    public Vector2 SizeDelta;
    // Use this for initialization
    void Start()
    {
        _myRectTransform = GetComponent<RectTransform>();
    }

    void OnValidate()
    {
        SetOffset();
    }

    // Update is called once per frame
    void SetOffset()
    {
        _myRectTransform.sizeDelta = SizeDelta;

    }

}
