using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class RectMovment : MonoBehaviour
{
    public float speed = 1;
    private RectTransform _myRectTransform;
	// Use this for initialization
	void Start ()
	{
	    _myRectTransform = GetComponent<RectTransform>();

	    

    }
	
	// Update is called once per frame
	void Update ()
	{
        _myRectTransform.anchoredPosition += Vector2.up * Input.GetAxis("Vertical") * speed;
	    _myRectTransform.anchoredPosition += Vector2.right * Input.GetAxis("Horizontal") * speed;

	    
	}
}
